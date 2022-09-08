using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.Interfaces.UserControls.Common
{
    public interface ILabelTextboxUcPresenter
    {
        ILabelTextBoxUCView GetUserControlView();
        void SetText(string text);
        string GetTextBoxValue();
        void SetValue(string text);
    }
}