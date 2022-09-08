using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.Interfaces.UserControls.Transactions
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