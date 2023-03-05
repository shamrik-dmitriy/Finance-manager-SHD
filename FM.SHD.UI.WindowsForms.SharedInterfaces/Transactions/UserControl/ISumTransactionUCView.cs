using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl
{
    public interface ISumTransactionUCView : IUserControlView
    {
        decimal GetSum();
        void SetSum(decimal sum);
    }
}