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
    public partial class SelectAccountUserControl : UserControl
    {
        private int TransactionType { get; }

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

            flowLayoutPanel1.Controls.Remove(creditAccountInfoUserControl);
            switch (TransactionType)
            {
                case 0:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Списать со счёта";
                        break;
                    }
                case 1:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
                        break;
                    }
                case 2:
                    {
                        debitAccountInfoUserControl.LabelOfTypeOperation = "Списать со счёта";
                        flowLayoutPanel1.Controls.Add(creditAccountInfoUserControl);
                        creditAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
                        break;
                    }
            }
            flowLayoutPanel1.Refresh();
            flowLayoutPanel1.Update();
        }

        private void debitAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
