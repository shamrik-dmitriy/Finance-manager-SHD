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

        public void OnUpdateTransaction(TransactionDto dto)
        {
            var oldTransactionDto = _transactionServices.GetById(dto.Id);
            if (dto.Equals(oldTransactionDto)) return;

            var oldTypeTransaction = (TransactionType)oldTransactionDto.TypeTransactionId;
            var newTypeTransaction = (TransactionType)dto.TypeTransactionId;
/* TODO: Додедлать
 *  - узнаём поменялись ли счета
 *      - если счета не поменялись
 *          - меняем тип операции у счёта на поле [CurrentSum] с - на +
 *          - обновляем счёт;
 *      - если счета поменялись
 *          1. Смена типа транзакции с "Расход" на "Доход"
 *              - узнаем с какого счёта будет списана сумма дохода (расход)
 *              - узнаем на какой счёт будет начислена сумма дохода (доход)
 *              - на счёте, который был раньше "Расходом" возвращаем поле [CurrentSum]
 *              в предыдущее значение (Делаем + по полю на текущую сумму), и на счёте
 *              который стал "Доходом" делаем также + по полю (т.е. старый счёт вернули как было, а новый обновили)
 *              - меняем счета в моделе данных;
 *          2. Смена типа транзакции с "Доход" на "Расход"
 *              - узнаем с какого счёта будет списана сумма дохода
 *              - узнаем на какой счёт будет начислена сумма дохода (расход)
 *              - на счёте, который был раньше "Доходом" возвращаем поле [CurrentSum]
 *              в предыдущее значение (Делаем - по полю на текущую сумму), и на счёте
 *              который стал "Расходом" делаем также- по полю (т.е. старый счёт вернули как было, а новый обновили)
 *              - меняем счета в моделе данных;
 *          3. Смена типа транзакции с "Доход" на "Перевод"
 *              - узнаем счёт на который была начислена сумма дохода (доход)
 *              - узнаем счёт на который будет начислена сумма перевода со счёта дохода
 *              - у счёта (доход) снимаем (минусуем) сумму дохода по полю [CurrnetSum]
 *                и добавляем её к счёту на который переводим
 *              - обновляем информацию о счетах
 *          4. Смена типа транзакции с "Расход" на "Перевод"
 *              - узнаем счёт с которого была списана сумма расхода (расход)
 *              - узнаем счёт на который будет начислена сумма перевода со счёта расхода
 *              - у счёта (расход) снимаем (минусуем) сумму дохода по полю [CurrnetSum]
 *                и добавляем её к счёту на который переводим
 *              - обновляем информацию о счетах
 */
            if (oldTypeTransaction != newTypeTransaction)
            {
                if (oldTypeTransaction == TransactionType.Expense
                    &&
                    newTypeTransaction == TransactionType.Income)
                {
                    var expenseAccount = _accountServices.GetById((long)dto.DebitAccountId);
                    expenseAccount.CurrentSum += dto.Sum;
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


            if (oldTransactionDto.Description != dto.Description)
                oldTransactionDto.Description = dto.Description;
            if (oldTransactionDto.DebitAccountId != dto.DebitAccountId)
                oldTransactionDto.DebitAccountId = dto.DebitAccountId;
            if (oldTransactionDto.CreditAccountId != dto.CreditAccountId)
                oldTransactionDto.CreditAccountId = dto.CreditAccountId;
            if (oldTransactionDto.Sum != dto.Sum)
            {
                oldTransactionDto.Sum = dto.Sum;
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
            }

            if (oldTransactionDto.Date != dto.Date)
                oldTransactionDto.Date = dto.Date;
            if (oldTransactionDto.CategoryId != dto.CategoryId)
                oldTransactionDto.CategoryId = dto.CategoryId;
            if (oldTransactionDto.CategoryId != dto.CategoryId)
                oldTransactionDto.CategoryId = dto.CategoryId;
            if (oldTransactionDto.IdentityId != dto.IdentityId)
                oldTransactionDto.IdentityId = dto.IdentityId;
            _transactionServices.Update(oldTransactionDto);
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