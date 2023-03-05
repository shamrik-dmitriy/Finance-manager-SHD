using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Name
{
    public interface INameTextboxUCView : IUserControlView
    {
        string GetName();
        void SetName(string name);
    }
}