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
                        resultTransactionDto.DebitAccountId =
                            oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId
                                ? newTransactionDto.DebitAccountId
                                : oldTransactionDto.DebitAccountId;
                        // Изменилась ли сумма транзакции
                        AmountCorrection(newTransactionDto, oldTransactionDto, resultTransactionDto);

                        break;
                    }
                    // Доход
                    case TransactionType.Income:
                    {
                        // Изменился ли счёт
                        resultTransactionDto.CreditAccountId =
                            oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId
                                ? newTransactionDto.CreditAccountId
                                : oldTransactionDto.CreditAccountId;
                        // Изменилась ли сумма транзакции
                        AmountCorrection(newTransactionDto, oldTransactionDto, resultTransactionDto);

                        break;
                    }
                    // Перевод
                    case TransactionType.Transfer:
                    {
                        if (oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId)
                        {
                        }

                        if (oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId)
                        {
                        }

                        break;
                    }
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
/* TODO: Ниже удалить*/


            if (oldTypeTransaction != newTypeTransaction)
            {
                if (oldTypeTransaction == TransactionType.Expense
                    &&
                    newTypeTransaction == TransactionType.Income)
                {
                    var expenseAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                    expenseAccount.CurrentSum += newTransactionDto.Sum;
                    _accountServices.Update(expenseAccount);
                }
                else if (oldTypeTransaction == TransactionType.Income
                         &&
                         newTypeTransaction == TransactionType.Expense)
                {
                }
                else if (newTypeTransaction == TransactionType.Transfer)
                {
                }
                //oldTransactionDto.TypeTransactionId = dto.TypeTransactionId;
            }

            if (oldTransactionDto.Description != newTransactionDto.Description)
                oldTransactionDto.Description = newTransactionDto.Description;
            if (oldTransactionDto.DebitAccountId != newTransactionDto.DebitAccountId)
                oldTransactionDto.DebitAccountId = newTransactionDto.DebitAccountId;
            if (oldTransactionDto.CreditAccountId != newTransactionDto.CreditAccountId)
                oldTransactionDto.CreditAccountId = newTransactionDto.CreditAccountId;

            if (oldTransactionDto.Sum != newTransactionDto.Sum)
            {
                oldTransactionDto.Sum = newTransactionDto.Sum;
                switch ((TransactionType)newTransactionDto.TypeTransactionId)
                {
                    case TransactionType.Expense:
                    {
                        var expenseAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                        expenseAccount.CurrentSum += newTransactionDto.Sum;
                        _accountServices.Update(expenseAccount);
                        break;
                    }
                    case TransactionType.Income:
                    {
                        var incomeAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                        incomeAccount.CurrentSum -= newTransactionDto.Sum;
                        _accountServices.Update(incomeAccount);
                        break;
                    }
                    case TransactionType.Transfer:
                    {
                        var expenseAccount = _accountServices.GetById((long)newTransactionDto.DebitAccountId);
                        expenseAccount.CurrentSum += newTransactionDto.Sum;

                        var incomeAccount = _accountServices.GetById((long)newTransactionDto.CreditAccountId);
                        incomeAccount.CurrentSum -= newTransactionDto.Sum;

                        _accountServices.Update(expenseAccount);
                        _accountServices.Update(incomeAccount);
                        break;
                    }
                }
            }

            if (oldTransactionDto.Date != newTransactionDto.Date)
                oldTransactionDto.Date = newTransactionDto.Date;
            if (oldTransactionDto.CategoryId != newTransactionDto.CategoryId)
                oldTransactionDto.CategoryId = newTransactionDto.CategoryId;
            if (oldTransactionDto.CategoryId != newTransactionDto.CategoryId)
                oldTransactionDto.CategoryId = newTransactionDto.CategoryId;
            if (oldTransactionDto.IdentityId != newTransactionDto.IdentityId)
                oldTransactionDto.IdentityId = newTransactionDto.IdentityId;
            _transactionServices.Update(oldTransactionDto);
        }

        private static void AmountCorrection(TransactionDto newTransactionDto, TransactionDto oldTransactionDto,
            TransactionDto resultTransactionDto)
        {
            if (oldTransactionDto.Sum != newTransactionDto.Sum)
            {
                var deltaSum = newTransactionDto.Sum - oldTransactionDto.Sum;
                resultTransactionDto.Sum = deltaSum switch
                {
                    > 0 => oldTransactionDto.Sum += deltaSum,
                    < 0 => oldTransactionDto.Sum -= deltaSum,
                    _ => resultTransactionDto.Sum
                };
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