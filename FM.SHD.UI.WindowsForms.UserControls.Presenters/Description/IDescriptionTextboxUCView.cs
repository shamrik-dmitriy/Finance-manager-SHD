using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Description
{
    public interface IDescriptionTextboxUCView : IUserControlView
    {
        string GetDescription();
        void SetDescription(string description);
    }
}