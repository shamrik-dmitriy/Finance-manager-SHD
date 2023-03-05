namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Name
{
    public class NameUcPresenter : INameUCPresenter
    {
        private readonly INameTextboxUCView _nameTextboxUcView;

        public NameUcPresenter(
            INameTextboxUCView nameTextboxUcView)
        {
            _nameTextboxUcView = nameTextboxUcView;
        }

        public INameTextboxUCView GetUserControlView()
        {
            return _nameTextboxUcView;
        }

        public string GetName()
        {
            return _nameTextboxUcView.GetName();
        }
    }
}