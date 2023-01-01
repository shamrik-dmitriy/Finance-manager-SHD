using System;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.TransactionServices;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Domain
{
    public class TransactionsDomain
    {
        private readonly EventAggregator _eventAggregator;
        private readonly ITransactionServices _transactionServices;
        private readonly IAccountServices _accountServices;

        public TransactionsDomain(
            EventAggregator eventAggregator,
            ITransactionServices transactionServices,
            IAccountServices accountServices
        )
        {
            _eventAggregator = eventAggregator;
            _transactionServices = transactionServices;
            _accountServices = accountServices;
        }

        public void OnAddedTransaction(TransactionDto dto)
        {
            switch ((TransactionType)dto.TypeTransactionId)
            {
                case TransactionType.Expense:
                {
                    var expenseAccount = _accountServices.GetById((long)dto.DebitAccountId);
                    expenseAccount.CurrentSum -= dto.Sum;
                    _accountServices.Update(expenseAccount);
                    break;
                }
                case TransactionType.Income:
                {
                    var incomeAccount = _accountServices.GetById((long)dto.CreditAccountId);
                    incomeAccount.CurrentSum += dto.Sum;
                    _accountServices.Update(incomeAccount);
                    break;
                }
                case TransactionType.Transfer:
                {
                    var expenseAccount = _accountServices.GetById((long)dto.DebitAccountId);
                    expenseAccount.CurrentSum -= dto.Sum;

                    var incomeAccount = _accountServices.GetById((long)dto.CreditAccountId);
                    incomeAccount.CurrentSum += dto.Sum;

                    _accountServices.Update(expenseAccount);
                    _accountServices.Update(incomeAccount);
                    break;
                }
            }

            _transactionServices.Add(dto);
        }

        public void OnUpdateTransaction(TransactionDto newTransactionDto)
        {
            TransactionDto resultTransactionDto = new TransactionDto();

            // Расход - дебит счёт, доход - кредит счёт.
            var oldTransactionDto = _transactionServices.GetById(newTransactionDto.Id);
            if (newTransactionDto.Equals(oldTransactionDto)) return;

            var oldTypeTransaction = (TransactionType)oldTransactionDto.TypeTransactionId;
            var newTypeTransaction = (TransactionType)newTransactionDto.TypeTransactionId;

            if (oldTypeTransaction != newTypeTransaction)
                ProcessingOfTypeTransactionHasChanged(newTransactionDto, oldTypeTransaction, newTypeTransaction,
                    oldTransactionDto, resultTransactionDto);
            else
                ProcessingOfTypeTransactionHasNotChanged(newTransactionDto, oldTypeTransaction, resultTransactionDto,
                    oldTransactionDto);

            // Поля, от которых независит какое-либо изменение внутри транзакций и счетов
            resultTransactionDto.Name = oldTransactionDto.Name != newTransactionDto.Name
                ? newTransactionDto.Name
                : oldTransactionDto.Name;
            resultTransactionDto.Description = oldTransactionDto.Description != newTransactionDto.Description
                ? newTransactionDto.Description
                : oldTransactionDto.Description;
            resultTransactionDto.Date = oldTransactionDto.Date != newTransactionDto.Date
                ? newTransactionDto.Date
                : oldTransactionDto.Date;
            resultTransactionDto.CategoryId = oldTransactionDto.CategoryId != newTransactionDto.CategoryId
                ? newTransactionDto.CategoryId
                : oldTransactionDto.CategoryId;
            resultTransactionDto.ContragentId = oldTransactionDto.ContragentId != newTransactionDto.ContragentId
                ? newTransactionDto.ContragentId
                : oldTransactionDto.ContragentId;
            resultTransactionDto.IdentityId = oldTransactionDto.IdentityId != newTransactionDto.IdentityId
                ? newTransactionDto.IdentityId
                : oldTransactionDto.IdentityId;
            _transactionServices.Update(resultTransactionDto);
        }

        private void ProcessingOfTypeTransactionHasChanged(TransactionDto newTransactionDto,
            TransactionType oldTypeTransaction,
            TransactionType newTypeTransaction, TransactionDto oldTransactionDto, TransactionDto resultTransactionDto)
        {
            // Узнаем какой тип транзакции был
            switch (oldTypeTransaction)
            {
                // Расход, счёт списания - debit
                case TransactionType.Expense:
                {
                    switch (newTypeTransaction)
                    {
                        // Доход, счёт пополнения - credit
                        case TransactionType.Income:
                        {
                            if (oldTransactionDto.DebitAccountId != newTransactionDto.CreditAccountId)
                            {
                                // Счёт списания был изменён
                                resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                accountDto.CurrentSum -= oldTransactionDto.Sum;
                                accountDto.CurrentSum += newTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }
                            else
                            {
                                // Счёт списания не был изменён
                                resultTransactionDto.CreditAccountId = oldTransactionDto.DebitAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                accountDto.CurrentSum -= oldTransactionDto.Sum;
                                accountDto.CurrentSum += newTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }

                            break;
                        }
                        // Перевод, счёт списания - debit, счёт пополнения - credit
                        case TransactionType.Transfer:
                        {
                            if (oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId)
                            {
                                // Счёт списания был изменён
                                resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var oldAccountDto =
                                    _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                oldAccountDto.CurrentSum += oldTransactionDto.Sum;
                                _accountServices.Update(oldAccountDto);

                                var newAccountDto =
                                    _accountServices.GetById((long)resultTransactionDto.DebitAccountId);
                                newAccountDto.CurrentSum -= newTransactionDto.Sum;
                                _accountServices.Update(newAccountDto);
                            }
                            else
                            {
                                // Счёт списания не был изменён
                                resultTransactionDto.DebitAccountId = oldTransactionDto.DebitAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.DebitAccountId);
                                accountDto.CurrentSum += oldTransactionDto.Sum;
                                accountDto.CurrentSum -= resultTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }

                            // Добавляется счёт зачисления
                            resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;
                            resultTransactionDto.Sum = newTransactionDto.Sum;

                            var creditAccountDto =
                                _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                            creditAccountDto.CurrentSum += resultTransactionDto.Sum;
                            _accountServices.Update(creditAccountDto);

                            break;
                        }
                    }

                    break;
                }
                // Доход, счёт пополнения - credit
                case TransactionType.Income:
                {
                    switch (newTypeTransaction)
                    {
                        // Расход, счёт списания - debit
                        case TransactionType.Expense:
                        {
                            if (oldTransactionDto.CreditAccountId != newTransactionDto.DebitAccountId)
                            {
                                // Счёт пополнения был изменён
                                resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                accountDto.CurrentSum += oldTransactionDto.Sum;
                                accountDto.CurrentSum -= newTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }
                            else
                            {
                                // Счёт пополнения не был изменён
                                resultTransactionDto.DebitAccountId = oldTransactionDto.CreditAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.DebitAccountId);
                                accountDto.CurrentSum += oldTransactionDto.Sum;
                                accountDto.CurrentSum -= newTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }

                            break;
                        }
                        // Перевод, счёт списания - debit, счёт пополнения - credit
                        case TransactionType.Transfer:
                        {
                            if (oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId)
                            {
                                // Счёт пополнения был изменён
                                resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var oldAccountDto =
                                    _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                oldAccountDto.CurrentSum -= oldTransactionDto.Sum;
                                _accountServices.Update(oldAccountDto);

                                var newAccountDto =
                                    _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                newAccountDto.CurrentSum += newTransactionDto.Sum;
                                _accountServices.Update(newAccountDto);
                            }
                            else
                            {
                                // Счёт пополнения не был изменён
                                resultTransactionDto.CreditAccountId = oldTransactionDto.CreditAccountId;
                                resultTransactionDto.Sum = newTransactionDto.Sum;

                                var accountDto =
                                    _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                accountDto.CurrentSum -= oldTransactionDto.Sum;
                                accountDto.CurrentSum += resultTransactionDto.Sum;
                                _accountServices.Update(accountDto);
                            }

                            // Добавляется поле списать со счёта
                            resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
                            resultTransactionDto.Sum = newTransactionDto.Sum;

                            var debitAccountDto =
                                _accountServices.GetById((long)resultTransactionDto.DebitAccountId);
                            debitAccountDto.CurrentSum -= resultTransactionDto.Sum;
                            _accountServices.Update(debitAccountDto);

                            break;
                        }
                    }

                    break;
                }
                // Перевод, счёт списания - debit, счёт пополнения - credit
                case TransactionType.Transfer:
                {
                    switch (newTypeTransaction)
                    {
                        // Корректируется и удаляется счёт списания - debit, корректируется счёт пополнения - credit
                        case TransactionType.Income:
                        {
                            break;
                        }
                        // Корректируется и удаляется счёт пополнения - credit, корректируется счёт списания - debit
                        case TransactionType.Expense:
                        {
                            break;
                        }
                    }

                    break;
                }
            }
        }

        private void ProcessingOfTypeTransactionHasNotChanged(TransactionDto newTransactionDto,
            TransactionType oldTypeTransaction, TransactionDto resultTransactionDto, TransactionDto oldTransactionDto)
        {
            switch (oldTypeTransaction)
            {
                case TransactionType.Expense:
                {
                    resultTransactionDto.Sum = newTransactionDto.Sum;

                    // Обновление счёта списания
                    resultTransactionDto.DebitAccountId =
                        oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId
                            ? newTransactionDto.DebitAccountId
                            : oldTransactionDto.DebitAccountId;

                    resultTransactionDto.Sum = newTransactionDto.Sum;

                    var accountDto =
                        _accountServices.GetById((long)resultTransactionDto.DebitAccountId);
                    accountDto.CurrentSum += oldTransactionDto.Sum;
                    accountDto.CurrentSum -= newTransactionDto.Sum;
                    _accountServices.Update(accountDto);

                    break;
                }
                case TransactionType.Income:
                {
                    // Обновление счёта пополнения
                    resultTransactionDto.CreditAccountId =
                        oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId
                            ? newTransactionDto.CreditAccountId
                            : oldTransactionDto.CreditAccountId;
                    resultTransactionDto.Sum = newTransactionDto.Sum;

                    var accountDto =
                        _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                    accountDto.CurrentSum -= oldTransactionDto.Sum;
                    accountDto.CurrentSum += newTransactionDto.Sum;
                    _accountServices.Update(accountDto);

                    break;
                }
                // Перевод
                case TransactionType.Transfer:
                {
                    resultTransactionDto.Sum = newTransactionDto.Sum;
                    
                    // Обновление счёта списания
                    resultTransactionDto.DebitAccountId =
                        oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId
                            ? newTransactionDto.DebitAccountId
                            : oldTransactionDto.DebitAccountId;

                    resultTransactionDto.Sum = newTransactionDto.Sum;

                    if (resultTransactionDto.DebitAccountId != oldTransactionDto.DebitAccountId)
                    {
                        // Корректировка суммы
                        var oldAccountDto =
                            _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                        var newAccountDto =
                            _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                        oldAccountDto.CurrentSum += oldTransactionDto.Sum;
                        newAccountDto.CurrentSum -= newTransactionDto.Sum;
                        _accountServices.Update(oldAccountDto);
                        _accountServices.Update(newAccountDto);
                    }
                    else
                    {
                        if (resultTransactionDto.Sum - oldTransactionDto.Sum > 0)
                        {
                            // Корректировка суммы
                            var currentAccountDto =
                                _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                            currentAccountDto.CurrentSum += oldTransactionDto.Sum;
                            currentAccountDto.CurrentSum -= newTransactionDto.Sum;
                            _accountServices.Update(currentAccountDto);
                        }
                    }

                    // Обновление счёта пополнения
                    resultTransactionDto.CreditAccountId =
                        oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId
                            ? newTransactionDto.CreditAccountId
                            : oldTransactionDto.CreditAccountId;

                    if (resultTransactionDto.CreditAccountId != oldTransactionDto.CreditAccountId)
                    {
                        // Корректировка суммы
                        var oldAccountDto =
                            _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                        var newAccountDto =
                            _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                        oldAccountDto.CurrentSum -= oldTransactionDto.Sum;
                        newAccountDto.CurrentSum += newTransactionDto.Sum;
                        _accountServices.Update(oldAccountDto);
                        _accountServices.Update(newAccountDto);
                    }
                    else
                    {
                        if (resultTransactionDto.Sum - oldTransactionDto.Sum > 0)
                        {
                            // Корректировка суммы
                            var currentAccountDto =
                                _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                            currentAccountDto.CurrentSum -= oldTransactionDto.Sum;
                            currentAccountDto.CurrentSum += newTransactionDto.Sum;
                            _accountServices.Update(currentAccountDto);
                        }
                    }

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(oldTypeTransaction));
            }
        }

        public void OnDeleteTransaction(TransactionDto dto)
        {
            switch ((TransactionType)dto.TypeTransactionId)
            {
                case TransactionType.Expense:
                {
                    var expenseAccount = _accountServices.GetById((long)dto.DebitAccountId);
                    expenseAccount.CurrentSum += dto.Sum;
                    _accountServices.Update(expenseAccount);
                    break;
                }
                case TransactionType.Income:
                {
                    var incomeAccount = _accountServices.GetById((long)dto.CreditAccountId);
                    incomeAccount.CurrentSum -= dto.Sum;
                    _accountServices.Update(incomeAccount);
                    break;
                }
                case TransactionType.Transfer:
                {
                    var expenseAccount = _accountServices.GetById((long)dto.DebitAccountId);
                    expenseAccount.CurrentSum += dto.Sum;

                    var incomeAccount = _accountServices.GetById((long)dto.CreditAccountId);
                    incomeAccount.CurrentSum -= dto.Sum;

                    _accountServices.Update(expenseAccount);
                    _accountServices.Update(incomeAccount);
                    break;
                }
            }

            _transactionServices.DeleteById(dto.Id);
        }
    }
}