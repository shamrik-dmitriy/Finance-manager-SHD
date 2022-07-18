using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls
{
    public partial class SumTransactionUserControl : UserControl
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

        public SumTransactionUserControl()
        {
            InitializeComponent();
        }
    }
}
