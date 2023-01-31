using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions
{
    public interface ISumTransactionUCPresenter
    {
        ISumTransactionUCView GetUserControlView();
        decimal GetSum();
        void SetSum(decimal sum);
    }
}