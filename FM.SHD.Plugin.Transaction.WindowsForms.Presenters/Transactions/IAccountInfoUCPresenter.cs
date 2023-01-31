using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters.Transactions
{
    public interface IAccountInfoUCPresenter
    {
        IAccountInfoUCView GetUserControlView();
        void SetText(string text);
        void SetVisible(bool visible);
    }
}