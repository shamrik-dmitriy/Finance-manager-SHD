using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions
{
    public interface ISumTransactionUCView : IUserControlView
    {
        decimal GetSum();
        void SetSum(decimal sum);
    }
}