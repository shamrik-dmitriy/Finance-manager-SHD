using System;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
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