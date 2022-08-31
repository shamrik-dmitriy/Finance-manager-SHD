using System;
using System.Windows.Forms;
using FM.SHD.Presenters.Interfaces.UserControls.Transactions;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class SumTransactionUCView : UserControl, ISumTransactionUCView
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
            get { return sumTextBox.Text; }
            set { sumTextBox.Text = value + "₽"; }
        }

        public bool IsEnabledSumField
        {
            set => sumTextBox.Enabled = value;
        }

        public SumTransactionUCView()
        {
            InitializeComponent();
        }

        public decimal GetSum()
        {
            return Sum;
        }
    }
}
