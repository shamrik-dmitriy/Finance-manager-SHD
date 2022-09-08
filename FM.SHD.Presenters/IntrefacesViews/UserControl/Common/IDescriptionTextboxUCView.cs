namespace FM.SHD.Presenters.IntrefacesViews.UserControl.Common
{
    public interface IDescriptionTextboxUCView : IUserControlView
    {
        string GetDescription();
        void SetDescription(string description);
    }
}