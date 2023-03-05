using System;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Additional.Transactions.UserControlsOfTransactions
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

        public void SetSum(decimal sum)
        {
            Sum = sum;
        }
    }
}
