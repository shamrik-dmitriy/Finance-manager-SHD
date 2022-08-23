using System;

namespace FM.SHD.Presenters.IntrefacesViews
{
    public interface IView
    {
        event Action OnLoadView;
        void ShowDialog();
        void ShowDialog(string title);
        void Show();
        void CloseView();
    }
}