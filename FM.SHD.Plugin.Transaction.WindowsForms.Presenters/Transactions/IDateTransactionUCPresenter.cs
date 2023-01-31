using System;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions
{
    public interface IDateTransactionUCPresenter
    {
        IDateTransactionUCView GetUserControlView();
        DateTime GetDate();
        void SetDate(DateTime date);
    }
}