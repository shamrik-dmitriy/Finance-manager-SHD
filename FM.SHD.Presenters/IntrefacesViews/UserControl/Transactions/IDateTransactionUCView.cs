using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface IDateTransactionUCView : IUserControlView
    {
        DateTime GetDate();
        void SetDate(DateTime date);
    }
}