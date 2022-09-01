namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ILabelTextBoxUCView : IUserControlView
    {
        void SetLabelText(string text);
        string GetTextBoxValue();
        void SetTextBoxValue(string text);
    }
}