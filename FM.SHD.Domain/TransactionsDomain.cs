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
            OnDeleteTransaction(oldTransactionDto);
            OnAddedTransaction(dto);
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