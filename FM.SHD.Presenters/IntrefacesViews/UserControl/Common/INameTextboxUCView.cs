namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface INameTextboxUCView : IUserControlView
    {
        string GetName();
        void SetName(string name);
    }
}