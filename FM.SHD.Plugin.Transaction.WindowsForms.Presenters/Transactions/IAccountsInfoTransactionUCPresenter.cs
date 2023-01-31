using System;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions
{
    public interface IAccountsInfoTransactionUCPresenter
    {
        IAccountsInfoTransactionUCView GetUserControlView();

        void CategoryChanged(long id);
       long? GetDebitAccountId();
       long? GetCreditAccountId();
       decimal GetSum();
       DateTime GetDate();
       void SetDate(DateTime date);
       void SetSum(decimal sum);
       void SetCreditAccountId(long? creditAccountId);
       void SetDebitAccountId(long? debitAccountId);
    }
}