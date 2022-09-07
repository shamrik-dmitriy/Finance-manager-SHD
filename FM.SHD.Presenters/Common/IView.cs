using System;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.Common
{
    public interface IView
    {
        event Action OnLoadView;
        void Show();
        void Close();
        void SetTitle(string title);
        void AddUserControl(IUserControlView userControlView);
        void AddHorizontalLine();
    }
}