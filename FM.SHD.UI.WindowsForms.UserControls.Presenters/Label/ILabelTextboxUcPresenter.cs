namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Label
{
    public interface ILabelTextboxUcPresenter
    {
        ILabelTextBoxUCView GetUserControlView();
        void SetText(string text);
        string GetTextBoxValue();
        void SetValue(string text);
    }
}