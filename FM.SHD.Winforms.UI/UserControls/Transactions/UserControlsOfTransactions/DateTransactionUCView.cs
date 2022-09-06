using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace FM.SHD.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class DateTransactionUCView : UserControl, IDateTransactionUCView
    {
        public DateTime Date
        {
            get => datePicker.Value.Date;
            set => datePicker.Value = value;
        }

        public TimeSpan Time
        {
            get => timePicker.Value.TimeOfDay;
            set => timePicker.Value = DateTime.Now.Add(value);
        }

        public DateTransactionUCView()
        {
            InitializeComponent();
        }

        public DateTime GetDate()
        {
            return Date + Time;
        }
    }
}