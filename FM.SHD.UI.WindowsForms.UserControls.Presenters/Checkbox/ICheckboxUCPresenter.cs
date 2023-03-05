namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Checkbox
{
    public interface ICheckboxUCPresenter
    {
        ICheckboxUCView GetUserControlView();

        void SetText(string text);
        bool GetCheckboxState();
    }
}