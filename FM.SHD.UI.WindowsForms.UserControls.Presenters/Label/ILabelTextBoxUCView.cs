using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Label
{
    public interface ILabelTextBoxUCView : IUserControlView
    {
        void SetLabelText(string text);
        string GetTextBoxValue();
        void SetTextBoxValue(string text);
    }
}