using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Winforms.UI.UserControls.Common
{
    public partial class CheckboxUCView : UserControl, ICheckboxUCView
    {
        public CheckboxUCView()
        {
            InitializeComponent();
        }

        public bool GetCheckboxState()
        {
            return checkBox1.Checked;
        }

        public void SetText(string text)
        {
            checkBox1.Text = text;
        }

        public void SetCheckboxState(bool isClosed)
        {
            checkBox1.CheckState = isClosed ? CheckState.Checked : CheckState.Unchecked;
        }
    }
}