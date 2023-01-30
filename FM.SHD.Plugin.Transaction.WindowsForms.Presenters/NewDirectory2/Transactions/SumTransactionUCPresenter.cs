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

        public decimal GetSum()
        {
            return _sumTransactionUcView.GetSum();
        }

        public void SetSum(decimal sum)
        {
            _sumTransactionUcView.SetSum(sum);
        }
    }
}