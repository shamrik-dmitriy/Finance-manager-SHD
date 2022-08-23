using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.Interfaces.UserControls.Transactions
{
    public interface IDateTransactionUCPresenter
    {
        IDateTransactionUCView GetUserControlView();
        DateTime GetDate();
    }
}