using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions
{
    public interface ISumTransactionUCView : IUserControlView
    {
        decimal GetSum();
        void SetSum(decimal sum);
    }
}