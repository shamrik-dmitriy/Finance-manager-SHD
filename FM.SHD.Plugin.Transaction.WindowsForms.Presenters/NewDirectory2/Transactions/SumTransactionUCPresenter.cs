using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory2.Transactions
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