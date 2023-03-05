using System;

namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.ContinueCancelButtons
{
    public class ContinueCancelButtonsUCPresenter : IContinueCancelButtonsUCPresenter
    {
        private readonly IContinueCancelButtonsUcView _continueCancelButtonsUcView;

        public ContinueCancelButtonsUCPresenter(IContinueCancelButtonsUcView continueCancelButtonsUcView)
        {
            _continueCancelButtonsUcView = continueCancelButtonsUcView;
            _continueCancelButtonsUcView.Continue+= ContinueCancelButtonsUcViewOnContinue;
            _continueCancelButtonsUcView.Cancel += ContinueCancelButtonsUcViewOnCancel;
            _continueCancelButtonsUcView.Delete += ContinueCancelButtonsUcViewOnDelete; 
        }

        private void ContinueCancelButtonsUcViewOnDelete()
        {
            Delete?.Invoke();
        }

        private void ContinueCancelButtonsUcViewOnCancel()
        {
            _continueCancelButtonsUcView.CloseParentView();
        }

        private void ContinueCancelButtonsUcViewOnContinue()
        {
            Continue?.Invoke();
        }

        public IContinueCancelButtonsUcView GetUserControlView()
        {
            return _continueCancelButtonsUcView;
        }

        public event Action Continue;
        public event Action Delete;
        
        public void SetTextButtonDelete(string text)
        {
            _continueCancelButtonsUcView.SetTextButtonDelete(text);
        }

        public void SetVisibleButtonDelete(bool isVisible)
        {
            _continueCancelButtonsUcView.SetVisibleButtonDelete(isVisible);
        }
        
        public void SetTextButtonContinue(string text)
        {
            _continueCancelButtonsUcView.SetTextButtonContinue(text);
        }

        public void SetTextButtonCancel(string text)
        {
            _continueCancelButtonsUcView.SetTextButtonCancel(text);
        }
    }
}