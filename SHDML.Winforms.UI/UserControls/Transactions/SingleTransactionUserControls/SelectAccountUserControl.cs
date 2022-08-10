using System;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class SelectAccountUserControl : UserControl
    {
        public decimal Sum => sumTransactionUserControl.Sum;

        private int TransactionType { get; set; }
        public string DebitAccount { get => debitAccountInfoUserControl.Name; set => debitAccountInfoUserControl.Name = value; }
        public string CreditAccount { get => creditAccountInfoUserControl.Name; set => creditAccountInfoUserControl.Name = value; }
        public DateTime Date { get => dateTransactionUserControl.Date; set => dateTransactionUserControl.Date = value; }
        public TimeSpan Time { get => dateTransactionUserControl.Time; set => dateTransactionUserControl.Time = value; }

        public SelectAccountUserControl()
        {
            InitializeComponent();
        }

        public SelectAccountUserControl(int transactionType) : this()
        {
            TransactionType = transactionType;
        }

        private void SelectAccountUserControl_Load(object sender, EventArgs e)
        {
            switch (TransactionType)
            {
                case 0:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Списать со счёта";
                        creditAccountInfoUserControl.Visible = false;
                        break;
                    }
                case 1:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Зачслить на счёт";
                        creditAccountInfoUserControl.Visible = false;
                        break;
                    }
                case 2:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Списать со счёта";
                        creditAccountInfoUserControl.Visible = true;
                        break;
                    }
            }
            //  financeInfoOfOperationflowLayoutPanel.Refresh();
            //financeInfoOfOperationflowLayoutPanel.Update();
        }

        private void debitAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
