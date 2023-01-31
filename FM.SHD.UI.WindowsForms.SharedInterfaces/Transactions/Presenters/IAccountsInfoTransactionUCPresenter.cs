using System;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters
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