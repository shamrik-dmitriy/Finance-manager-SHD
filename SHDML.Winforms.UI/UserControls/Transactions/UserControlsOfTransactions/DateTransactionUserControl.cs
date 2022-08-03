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
        public DateTime Date { get => datePicker.Value.Date; set => datePicker.Value = value; }
        public TimeSpan Time { get => timePicker.Value.TimeOfDay; set => timePicker.Value = DateTime.Now.Add(value); }

        public DateTransactionUserControl()
        {
            InitializeComponent();
        }
    }
}
