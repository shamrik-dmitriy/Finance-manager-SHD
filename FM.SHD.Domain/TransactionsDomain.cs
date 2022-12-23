﻿using System;
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

            // Тип транзакции поменялся
            if (oldTypeTransaction != newTypeTransaction)
            {
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
                        // Изменился ли счёт
                        resultTransactionDto.DebitAccountId = CheckChangeAccount(oldTransactionDto.DebitAccountId,
                            newTransactionDto.DebitAccountId);
                        // Изменилась ли сумма транзакции
                        CheckAccountsSum(newTransactionDto, oldTransactionDto, resultTransactionDto,
                            oldTypeTransaction);
                        break;
                    }
                    // Доход
                    case TransactionType.Income:
                    {
                        // Изменился ли счёт
                        resultTransactionDto.CreditAccountId = CheckChangeAccount(oldTransactionDto.CreditAccountId,
                            newTransactionDto.CreditAccountId);
                        // Изменилась ли сумма транзакции
                        CheckAccountsSum(newTransactionDto, oldTransactionDto, resultTransactionDto,
                            oldTypeTransaction);
                        break;
                    }
                    // Перевод
                    case TransactionType.Transfer:
                    {
                        // Изменился ли счёт списания
                        if (oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId)
                        {
                            resultTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;

                            // Изменилась ли сумма списания
                            if (newTransactionDto.Sum - oldTransactionDto.Sum != 0)
                            {
                                var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;

                                AccountDto oldAccount;
                                AccountDto newAccount;
                                switch (deltaSum)
                                {
                                    case > 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                        oldAccount.CurrentSum += oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                        newAccount.CurrentSum -= oldTransactionDto.Sum;
                                        newAccount.CurrentSum += deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                    case < 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                        oldAccount.CurrentSum -= oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                        newAccount.CurrentSum += oldTransactionDto.Sum;
                                        newAccount.CurrentSum -= deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                }
                            }
                            // Сумма списания не изменилась
                            else
                            {
                                var oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                oldAccount.CurrentSum += oldTransactionDto.Sum;
                                _accountServices.Update(oldAccount);

                                var newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                newAccount.CurrentSum -= oldTransactionDto.Sum;
                                _accountServices.Update(newAccount);
                            }
                        }
                        // Счёт списания не изменился
                        else
                        {
                            // Изменилась ли сумма списания
                            if (newTransactionDto.Sum - oldTransactionDto.Sum != 0)
                            {
                                var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;

                                AccountDto oldAccount;
                                AccountDto newAccount;
                                switch (deltaSum)
                                {
                                    case > 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                        oldAccount.CurrentSum += oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                        newAccount.CurrentSum -= oldTransactionDto.Sum;
                                        newAccount.CurrentSum += deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                    case < 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                        oldAccount.CurrentSum -= oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                        newAccount.CurrentSum += oldTransactionDto.Sum;
                                        newAccount.CurrentSum -= deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                }
                            }
                            // Сумма списания не изменилась
                            else
                            {
                                var oldAccount = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                                oldAccount.CurrentSum += oldTransactionDto.Sum;
                                _accountServices.Update(oldAccount);

                                var newAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                                newAccount.CurrentSum -= oldTransactionDto.Sum;
                                _accountServices.Update(newAccount);
                            }
                        }

                        // Изменился ли счёт пополнения
                        if (oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId)
                        {
                            resultTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;

                            // Изменилась ли сумма списания
                            if (newTransactionDto.Sum - oldTransactionDto.Sum != 0)
                            {
                                var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;

                                AccountDto oldAccount;
                                AccountDto newAccount;
                                switch (deltaSum)
                                {
                                    case > 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                        oldAccount.CurrentSum += oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                        newAccount.CurrentSum -= oldTransactionDto.Sum;
                                        newAccount.CurrentSum += deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                    case < 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                        oldAccount.CurrentSum -= oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                        newAccount.CurrentSum += oldTransactionDto.Sum;
                                        newAccount.CurrentSum -= deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                }
                            }
                            // Сумма списания не изменилась
                            else
                            {
                                var oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                oldAccount.CurrentSum += oldTransactionDto.Sum;
                                _accountServices.Update(oldAccount);

                                var newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                newAccount.CurrentSum -= oldTransactionDto.Sum;
                                _accountServices.Update(newAccount);
                            }
                        }
                        else
                        {
                            // Изменилась ли сумма списания
                            if (newTransactionDto.Sum - oldTransactionDto.Sum != 0)
                            {
                                var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;

                                AccountDto oldAccount;
                                AccountDto newAccount;
                                switch (deltaSum)
                                {
                                    case > 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                        oldAccount.CurrentSum += oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                        newAccount.CurrentSum -= oldTransactionDto.Sum;
                                        newAccount.CurrentSum += deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                    case < 0:
                                        oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                        oldAccount.CurrentSum -= oldTransactionDto.Sum;
                                        _accountServices.Update(oldAccount);

                                        newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                        newAccount.CurrentSum += oldTransactionDto.Sum;
                                        newAccount.CurrentSum -= deltaSum;
                                        _accountServices.Update(newAccount);
                                        break;
                                }
                            }
                            // Сумма списания не изменилась
                            else
                            {
                                var oldAccount = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                                oldAccount.CurrentSum += oldTransactionDto.Sum;
                                _accountServices.Update(oldAccount);

                                var newAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                                newAccount.CurrentSum -= oldTransactionDto.Sum;
                                _accountServices.Update(newAccount);
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

        private void CheckAccountsSum(TransactionDto newTransactionDto, TransactionDto oldTransactionDto,
            TransactionDto resultTransactionDto, TransactionType transactionType)
        {
            if (oldTransactionDto.Sum != newTransactionDto.Sum)
            {
                AccountDto accountDto;
                switch (transactionType)
                {
                    case TransactionType.Expense:
                    {
                        accountDto = _accountServices.GetById((long)oldTransactionDto.DebitAccountId);
                        AmountCorrection(newTransactionDto.Sum, oldTransactionDto.Sum, resultTransactionDto,
                            accountDto);

                        break;
                    }
                    case TransactionType.Income:
                    {
                        accountDto = _accountServices.GetById((long)oldTransactionDto.CreditAccountId);
                        AmountCorrection(newTransactionDto.Sum, oldTransactionDto.Sum, resultTransactionDto,
                            accountDto);
                        break;
                    }
                    case TransactionType.Transfer:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(transactionType), transactionType, null);
                }
            }
        }

        private void AmountCorrection(decimal newTransactionSum,
            decimal oldTransactionSum, TransactionDto resultTransactionDto, AccountDto accountDto)
        {
            var deltaSum = newTransactionSum - oldTransactionSum;

            switch (deltaSum)
            {
                case > 0:
                    resultTransactionDto.Sum = oldTransactionSum + deltaSum;
                    accountDto.CurrentSum += deltaSum;
                    _accountServices.Update(accountDto);
                    break;
                case < 0:
                    resultTransactionDto.Sum = oldTransactionSum - deltaSum;
                    accountDto.CurrentSum -= deltaSum;
                    _accountServices.Update(accountDto);
                    break;
            }
        }

        private long? CheckChangeAccount(long? oldTransactionAccountId, long? newTransactionAccountId)
        {
            return oldTransactionAccountId != newTransactionAccountId
                ? newTransactionAccountId
                : oldTransactionAccountId;
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