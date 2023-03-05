namespace FM.SHD.UI.WindowsForms.UserControls.Presenters.Label
{
    public class LabelTextboxPresenter : ILabelTextboxUcPresenter
    {
        private readonly ILabelTextBoxUCView _labelTextBoxUcView;

        public LabelTextboxPresenter(ILabelTextBoxUCView labelTextBoxUcView)
        {
            _labelTextBoxUcView = labelTextBoxUcView;
        }

        public ILabelTextBoxUCView GetUserControlView()
        {
            return _labelTextBoxUcView;
        }

        public void SetText(string text)
        {
            _labelTextBoxUcView.SetLabelText(text);
        }

        public string GetTextBoxValue()
        {
            return _labelTextBoxUcView.GetTextBoxValue();
        }

        public void SetValue(string text)
        {
            _labelTextBoxUcView.SetTextBoxValue(text);
        }
    }
}