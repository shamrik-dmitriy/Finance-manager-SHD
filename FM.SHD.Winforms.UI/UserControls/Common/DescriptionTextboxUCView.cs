using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace FM.SHD.Winforms.UI.UserControls.Common
{
    public partial class DescriptionTextboxUCView : UserControl, IDescriptionTextboxUCView
    {
        public DescriptionTextboxUCView()
        {
            InitializeComponent();
        }

        private void textBoxDescriptionTransaction_TextChanged(object sender, EventArgs e)
        {
        }

        public string GetDescription()
        {
            return textBoxDescriptionTransaction.Text;
        }

        public void SetDescription(string description)
        {
            textBoxDescriptionTransaction.Text = description;
        }
    }
}