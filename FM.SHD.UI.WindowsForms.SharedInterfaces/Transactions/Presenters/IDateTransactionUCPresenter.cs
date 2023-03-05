using System;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters
{
    public interface IDateTransactionUCPresenter
    {
        IDateTransactionUCView GetUserControlView();
        DateTime GetDate();
        void SetDate(DateTime date);
    }
}