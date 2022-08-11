using System;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class DateTransactionUCView : UserControl
    {
        public DateTime Date { get => datePicker.Value.Date; set => datePicker.Value = value; }
        public TimeSpan Time { get => timePicker.Value.TimeOfDay; set => timePicker.Value = DateTime.Now.Add(value); }

        public DateTransactionUCView()
        {
            InitializeComponent();
        }
    }
}
