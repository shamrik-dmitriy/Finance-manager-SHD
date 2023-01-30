using System;
using FM.SHD.UI.WindowsForms.Presenters;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Presenters
{
    public interface ITransactionBaseView : IBaseView
    {
        event Action OnLoadView;
        event EventHandler Add;
        event Action<int> OnChangeTypeTransaction;

        void AddUserControl(IUserControlView userControlView);
        void SetTitle(string title);
        void Clear();
        bool ShowMessageDelete(string title, string message);
    }
}