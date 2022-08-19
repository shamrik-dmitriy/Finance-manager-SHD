using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
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

        public DateTime GetDateTime()
        {
            return Date + Time;
        }
    }
}