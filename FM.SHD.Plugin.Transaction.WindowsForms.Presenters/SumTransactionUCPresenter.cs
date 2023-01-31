using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
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