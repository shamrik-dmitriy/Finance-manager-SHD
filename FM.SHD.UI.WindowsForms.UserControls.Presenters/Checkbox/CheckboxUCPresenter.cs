namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Checkbox
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

        public void SetText(string text)
        {
            _checkboxUcView.SetText(text);
        }

        public bool GetCheckboxState()
        {
            return _checkboxUcView.GetCheckboxState();
        }
    }
}