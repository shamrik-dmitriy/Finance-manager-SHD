using System;
using FM.SHD.Presenters.Interfaces.UserControls.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Presenters.UserControlPresenters.Common
{
    public class DataControlButtonsUcPresenter : IContinueCancelButtonsUCPresenter
    {
        private readonly IDataControlButtonsUCView _dataControlButtonsUcView;

        public DataControlButtonsUcPresenter(IDataControlButtonsUCView dataControlButtonsUcView)
        {
            _dataControlButtonsUcView = dataControlButtonsUcView;
            _dataControlButtonsUcView.Continue+= DataControlButtonsUcViewOnContinue;
            _dataControlButtonsUcView.Cancel += DataControlButtonsUcViewOnCancel;
            _dataControlButtonsUcView.Delete += DataControlButtonsUcViewOnDelete; 
        }

        private void DataControlButtonsUcViewOnDelete()
        {
            Delete?.Invoke();
        }

        private void DataControlButtonsUcViewOnCancel()
        {
            _dataControlButtonsUcView.CloseParentView();
        }

        private void DataControlButtonsUcViewOnContinue()
        {
            Continue?.Invoke();
        }

        public IDataControlButtonsUCView GetUserControlView()
        {
            return _dataControlButtonsUcView;
        }

        public event Action Continue;
        public event Action Delete;
        
        public void SetTextButtonDelete(string text)
        {
            _dataControlButtonsUcView.SetTextButtonDelete(text);
        }

        public void SetVisibleButtonDelete(bool isVisible)
        {
            _dataControlButtonsUcView.SetVisibleButtonDelete(isVisible);
        }
        
        public void SetTextButtonContinue(string text)
        {
            _dataControlButtonsUcView.SetTextButtonContinue(text);
        }

        public void SetTextButtonCancel(string text)
        {
            _dataControlButtonsUcView.SetTextButtonCancel(text);
        }
    }
}