using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions
{
    public interface IAccountInfoUCPresenter
    {
        IAccountInfoUCView GetUserControlView();
        void SetText(string text);
        void SetVisible(bool visible);
    }
}