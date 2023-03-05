using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Checkbox
{
    public interface ICheckboxUCView : IUserControlView
    {
        bool GetCheckboxState();
        void SetText(string text);
        void SetCheckboxState(bool isClosed);
    }
}