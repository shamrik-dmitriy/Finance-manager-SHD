using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
{
    public class SumTransactionUCPresenter : ISumTransactionUCPresenter
    {
        private readonly ISumTransactionUCView _sumTransactionUcView;

        public SumTransactionUCPresenter(
            ISumTransactionUCView sumTransactionUcView)
        {
            _sumTransactionUcView = sumTransactionUcView;
        }

        public ISumTransactionUCView GetUserControlView()
        {
            return _sumTransactionUcView;
        }
    }
}