using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class CheckboxUCPresenter : ICheckboxUCPresenter
    {
        private readonly ICheckboxUCView _checkboxUcView;

        public CheckboxUCPresenter(ICheckboxUCView checkboxUcView)
        {
            _checkboxUcView = checkboxUcView;
        }
        
        public ICheckboxUCView GetUserControlView()
        {
            return _checkboxUcView;
        }

        public bool GetCheckboxState()
        {
            return _checkboxUcView.GetCheckboxState();
        }
    }
}