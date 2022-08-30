using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class ContinueCancelButtonsUcPresenter : IContinueCancelButtonsUCPresenter
    {
        private readonly IAddCancelButtonsUCView _addCancelButtonsUcView;

        public ContinueCancelButtonsUcPresenter(IAddCancelButtonsUCView addCancelButtonsUcView)
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
        public void SetTextButtonContinue(string text)
        {
            _addCancelButtonsUcView.SetTextButtonContinue(text);
        }

        public void SetTextButtonCancel(string text)
        {
            _addCancelButtonsUcView.SetTextButtonCancel(text);
        }
    }
}