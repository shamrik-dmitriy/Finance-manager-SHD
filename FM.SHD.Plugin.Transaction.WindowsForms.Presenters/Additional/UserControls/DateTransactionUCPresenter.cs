using System;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Additional.UserControls
{
    public class DateTransactionUCPresenter : IDateTransactionUCPresenter
    {
        private readonly IDateTransactionUCView _dateTransactionUcView;

        public DateTransactionUCPresenter(IDateTransactionUCView dateTransactionUcView)
        {
            _dateTransactionUcView = dateTransactionUcView;
        }

        public IDateTransactionUCView GetUserControlView()
        {
            return _dateTransactionUcView;
        }

        public DateTime GetDate()
        {
            return _dateTransactionUcView.GetDate();
        }

        public void SetDate(DateTime date)
        {
            _dateTransactionUcView.SetDate(date);
        }
    }
}