using FM.SHD.Presenters.Interfaces.UserControls;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace FM.SHD.Presenters.UserControlPresenters
{
    public class AddCancelButtonsUCPresenter : IAddCancelButtonsUCPresenter
    {
        private readonly IAddCancelButtonsUCView _addCancelButtonsUcView;

        public AddCancelButtonsUCPresenter(IAddCancelButtonsUCView addCancelButtonsUcView)
        {
            _addCancelButtonsUcView = addCancelButtonsUcView;
        }

        public IAddCancelButtonsUCView GetUserControlView()
        {
            return _addCancelButtonsUcView;
        }
    }
}