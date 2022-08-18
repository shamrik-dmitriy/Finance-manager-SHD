using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ICheckboxUCPresenter
    {
        ICheckboxUCView GetUserControlView();

        void SetText(string text);
        bool GetCheckboxState();
    }
}