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
    public partial class DateTransactionUserControl : UserControl
    {
        public DateTime DateTime { get => dateTimePicker.Value.Date; set => dateTimePicker.Value = value; }

        public DateTransactionUserControl()
        {
            InitializeComponent();
        }
    }
}
