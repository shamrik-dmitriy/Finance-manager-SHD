using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
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