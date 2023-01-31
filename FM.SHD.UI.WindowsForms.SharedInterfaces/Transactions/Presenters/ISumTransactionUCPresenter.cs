using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.Presenters
{
    public interface ISumTransactionUCPresenter
    {
        ISumTransactionUCView GetUserControlView();
        decimal GetSum();
        void SetSum(decimal sum);
    }
}