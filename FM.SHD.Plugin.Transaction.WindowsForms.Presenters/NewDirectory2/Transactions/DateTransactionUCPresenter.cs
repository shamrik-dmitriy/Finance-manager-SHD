using System;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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