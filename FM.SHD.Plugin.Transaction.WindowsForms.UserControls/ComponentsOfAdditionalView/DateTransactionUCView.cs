using System;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls
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

        public void SetDate(DateTime date)
        {
            Date = date;
            Time = date.TimeOfDay;
        }
    }
}