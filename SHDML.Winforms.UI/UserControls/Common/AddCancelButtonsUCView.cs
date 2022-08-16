using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class AddCancelButtonsUCView : UserControl, IAddCancelButtonsUCView
    {
        public AddCancelButtonsUCView()
        {
            InitializeComponent();
        }

        private void AddCancelUCView_Load(object sender, EventArgs e)
        {
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Continue?.Invoke();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        public event Action Continue;
        public event Action Cancel;

        public void CloseParentView()
        {
            ((Form)TopLevelControl)?.Close();
        }
    }
}