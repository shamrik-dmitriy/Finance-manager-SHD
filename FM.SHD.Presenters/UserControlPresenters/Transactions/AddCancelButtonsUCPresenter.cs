using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Presenters.UserControlPresenters.Transactions
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