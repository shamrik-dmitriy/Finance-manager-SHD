using System;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.Presenters
{
    public interface IBaseView
    {
        event Action OnLoadView;
        void Show();
        void Close();
        void SetTitle(string title);
        void AddUserControl(IUserControlView userControlView);
        void AddHorizontalLine();
    }
}