using System;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Description;

namespace FM.SHD.UI.WindowsForms.UserControls.Views
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