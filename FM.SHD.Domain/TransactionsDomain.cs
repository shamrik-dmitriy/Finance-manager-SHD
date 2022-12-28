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

        private void TransferAccountChangedAmountNotChanged(TransactionDto oldTransactionDto,
            TransactionDto newTransactionDto, bool isDebit)
        {
            var oldAccount = _accountServices.GetById(isDebit
                ? (long)oldTransactionDto.DebitAccountId
                : (long)oldTransactionDto.CreditAccountId);
            oldAccount.CurrentSum += oldTransactionDto.Sum;
            _accountServices.Update(oldAccount);

            var newAccount = _accountServices.GetById(isDebit
                ? (long)oldTransactionDto.DebitAccountId
                : (long)oldTransactionDto.CreditAccountId);
            newAccount.CurrentSum -= oldTransactionDto.Sum;
            _accountServices.Update(newAccount);
        }

        private void TransferCheck2(TransactionDto newTransactionDto, TransactionDto oldTransactionDto, bool isDebit)
        {
            var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;

            AccountDto oldAccount;
            AccountDto newAccount;
            switch (deltaSum)
            {
                case > 0:
                    oldAccount = _accountServices.GetById(isDebit
                        ? (long)oldTransactionDto.DebitAccountId
                        : (long)oldTransactionDto.CreditAccountId);
                    oldAccount.CurrentSum += oldTransactionDto.Sum;
                    _accountServices.Update(oldAccount);

                    newAccount = _accountServices.GetById(isDebit
                        ? (long)oldTransactionDto.DebitAccountId
                        : (long)oldTransactionDto.CreditAccountId);
                    newAccount.CurrentSum -= oldTransactionDto.Sum;
                    newAccount.CurrentSum += deltaSum;
                    _accountServices.Update(newAccount);
                    break;
                case < 0:
                    oldAccount = _accountServices.GetById(isDebit
                        ? (long)oldTransactionDto.DebitAccountId
                        : (long)oldTransactionDto.CreditAccountId);
                    oldAccount.CurrentSum -= oldTransactionDto.Sum;
                    _accountServices.Update(oldAccount);

                    newAccount = _accountServices.GetById(isDebit
                        ? (long)oldTransactionDto.DebitAccountId
                        : (long)oldTransactionDto.CreditAccountId);
                    newAccount.CurrentSum += oldTransactionDto.Sum;
                    newAccount.CurrentSum -= deltaSum;
                    _accountServices.Update(newAccount);
                    break;
            }
        }

        public void OnUpdateTransaction(TransactionDto newTransactionDto)
        {
            TransactionDto resultTransactionDto = new TransactionDto();

            // Расход - дебит счёт, доход - кредит счёт.
            var oldTransactionDto = _transactionServices.GetById(newTransactionDto.Id);
            if (newTransactionDto.Equals(oldTransactionDto)) return;

            var oldTypeTransaction = (TransactionType)oldTransactionDto.TypeTransactionId;
            var newTypeTransaction = (TransactionType)newTransactionDto.TypeTransactionId;

            // Тип транзакции поменялся
            if (oldTypeTransaction != newTypeTransaction)
            {
                // Узнаем какой тип транзакции был
                switch (oldTypeTransaction)
                {
                    // Расход - debit
                    case TransactionType.Expense:
                    {
                        switch (newTypeTransaction)
                        {
                            // Доход - credit
                            case TransactionType.Income:
                            {
                                // Счета - был Debit, стал Credit
                                // Счёт был изменён
                                if (oldTransactionDto.DebitAccountId != newTransactionDto.CreditAccountId)
                                {
                                    resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;
                                    resultTransactionDto.Sum = newTransactionDto.Sum;

                                    var accountDto =
                                        _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                    accountDto.CurrentSum -= oldTransactionDto.Sum;
                                    accountDto.CurrentSum += newTransactionDto.Sum;
                                    _accountServices.Update(accountDto);
                                }
                                // Счёт не был изменён
                                else
                                {
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
                            // Перевод с Debit на Credit TODO 28.12.22 Переделать в соответствии с аналогом выше
                            case TransactionType.Transfer:
                            {
                                // Был расход, стал перевод
                                // Нужно узнать поменялся ли счёт
                                // Поменялся ли счёт Debit
                                if (oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId)
                                {
                                    resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
                                    resultTransactionDto.Sum = newTransactionDto.Sum;

                                    // Изменилась ли сумма
                                    var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;
                                    var accountDto =
                                        _accountServices.GetById((long)resultTransactionDto.DebitAccountId);

                                    switch (deltaSum)
                                    {
                                        case > 0:
                                            accountDto.CurrentSum += deltaSum;
                                            _accountServices.Update(accountDto);
                                            break;
                                        case < 0:
                                            accountDto.CurrentSum -= deltaSum;
                                            _accountServices.Update(accountDto);
                                            break;
                                    }
                                }
                                else
                                {
                                    resultTransactionDto.DebitAccountId = oldTransactionDto.DebitAccountId;
                                }

                                // Зачислить на счёт - поле добавляется
                                resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;
                                break;
                            }
                        }

                        break;
                    }
                    // Доход - credit
                    case TransactionType.Income:
                    {
                        switch (newTypeTransaction)
                        {
                            // Расход - debit
                            case TransactionType.Expense:
                            {
                                // Счета - был credit, стал debit
                                // Счёт был изменён
                                if (oldTransactionDto.CreditAccountId != newTransactionDto.DebitAccountId)
                                {
                                    resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
                                    resultTransactionDto.Sum = newTransactionDto.Sum;

                                    var accountDto =
                                        _accountServices.GetById((long)resultTransactionDto.CreditAccountId);
                                    accountDto.CurrentSum += oldTransactionDto.Sum;
                                    accountDto.CurrentSum -= newTransactionDto.Sum;
                                    _accountServices.Update(accountDto);
                                }
                                // Счёт не был изменён
                                else
                                {
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
                            // Перевод
                            case TransactionType.Transfer:
                            {
                                break;
                            }
                        }

                        break;
                    }
                    // Перевод
                    case TransactionType.Transfer:
                    {
                        switch (newTypeTransaction)
                        {
                            // Доход - credit
                            case TransactionType.Income:
                            {
                                break;
                            }
                            // Расход
                            case TransactionType.Expense:
                            {
                                break;
                            }
                        }

                        break;
                    }
                }
            }
            // Тип транзакции не поменялся
            else
            {
                // Узнаем какой тип транзакции был
                switch (oldTypeTransaction)
                {
                    // Расход
                    case TransactionType.Expense:
                    {
                        resultTransactionDto.Sum = newTransactionDto.Sum;

                        // Изменился счёт
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
                    // Доход
                    case TransactionType.Income:
                    {
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

                        // Изменился ли счёт списания
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


                        // Изменился ли счёт зачисления
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