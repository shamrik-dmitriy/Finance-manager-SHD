namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Description
{
    public interface IDescriptionUCPresenter
    {
        IDescriptionTextboxUCView GetUserControlView();
        string GetDescription();
    }
}