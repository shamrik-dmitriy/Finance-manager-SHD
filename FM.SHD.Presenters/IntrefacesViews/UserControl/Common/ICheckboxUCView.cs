namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface ICheckboxUCView : IUserControlView
    {
        bool GetCheckboxState();
        void SetText(string text);
        void SetCheckboxState(bool isClosed);
    }
}