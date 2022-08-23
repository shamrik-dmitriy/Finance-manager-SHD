using System;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface IDateTransactionUCView : IUserControlView
    {
        DateTime GetDate();
    }
}