using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface IDateTransactionUCView : IUserControlView
    {
        DateTime GetDate();
        void SetDate(DateTime date);
    }
}