using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

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
    }
}