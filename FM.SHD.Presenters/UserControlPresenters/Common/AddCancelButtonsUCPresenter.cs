using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class AddCancelButtonsUCPresenter : IAddCancelButtonsUCPresenter
    {
        private readonly IAddCancelButtonsUCView _addCancelButtonsUcView;

        public AddCancelButtonsUCPresenter(IAddCancelButtonsUCView addCancelButtonsUcView)
        {
            _addCancelButtonsUcView = addCancelButtonsUcView;
            _addCancelButtonsUcView.Continue+= AddCancelButtonsUcViewOnContinue;
            _addCancelButtonsUcView.Cancel += AddCancelButtonsUcViewOnCancel;
        }

        private void AddCancelButtonsUcViewOnCancel()
        {
            _addCancelButtonsUcView.CloseParentView();
        }

        private void AddCancelButtonsUcViewOnContinue()
        {
            Continue?.Invoke();
        }

        public IAddCancelButtonsUCView GetUserControlView()
        {
            return _addCancelButtonsUcView;
        }

        public event Action Continue;
    }
}