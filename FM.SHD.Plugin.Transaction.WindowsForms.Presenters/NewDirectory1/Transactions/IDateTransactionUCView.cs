using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions
{
    public interface IDateTransactionUCView : IUserControlView
    {
        DateTime GetDate();
        void SetDate(DateTime date);
    }
}