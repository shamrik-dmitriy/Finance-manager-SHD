using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class LabelTextBoxUCView : UserControl, ILabelTextBoxUCView
    {
        public decimal Sum
        {
            get
            {
                return string.IsNullOrWhiteSpace(_sum) ? 0 : Convert.ToDecimal(_sum.Trim('₽'));
            }
            set { _sum = value.ToString(); }
        }

        private string _sum
        {
            get { return textBox.Text; }
            set { textBox.Text = value + "₽"; }
        }

        public bool IsEnabledSumField
        {
            set => textBox.Enabled = value;
        }

        public LabelTextBoxUCView()
        {
            InitializeComponent();
        }

        public LabelTextBoxUCView(string labelText, string textboxDefaultValue) : this()
        {
            label.Text = labelText;
            textBox.Text = textboxDefaultValue;
        }

        public void SetLabelText(string text)
        {
            label.Text = text;
        }
    }
}
