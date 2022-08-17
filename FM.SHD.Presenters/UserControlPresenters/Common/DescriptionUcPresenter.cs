using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
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