using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.Interfaces.UserControls.Transactions
{
    public interface ISumTransactionUCPresenter
    {
        ISumTransactionUCView GetUserControlView();
        decimal GetSum();
        void SetSum(decimal sum);
    }
}