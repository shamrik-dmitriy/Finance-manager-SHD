namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Description
{
    public class DescriptionUcPresenter : IDescriptionUCPresenter
    {
        private readonly IDescriptionTextboxUCView _descriptionTextboxUcView;

        public DescriptionUcPresenter(IDescriptionTextboxUCView descriptionTextboxUcView)
        {
            _descriptionTextboxUcView = descriptionTextboxUcView;
        }

        public IDescriptionTextboxUCView GetUserControlView()
        {
            return _descriptionTextboxUcView;
        }

        public string GetDescription()
        {
            return _descriptionTextboxUcView.GetDescription();
        }
    }
}