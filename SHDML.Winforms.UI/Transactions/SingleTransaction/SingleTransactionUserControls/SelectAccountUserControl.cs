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

        public SelectAccountUserControl(int transactionType)
        {
            TransactionType = transactionType;
            InitializeComponent();
        }

        private void SelectAccountUserControl_Load(object sender, EventArgs e)
        {

            Controls.Remove(creditAccountLabel);
            Controls.Remove(creditAccountComboBox);
            switch (TransactionType)
            {
                case 0:
                    {
                        debitAccountLabel.Text = "Списать со счёта";
                        break;
                    }
                case 1:
                    {
                        debitAccountLabel.Text = "Зачислить на счёт";
                        break;
                    }
                case 2:
                    {
                        debitAccountLabel.Text = "Списать со счёта";
                        Controls.Add(creditAccountLabel);
                        creditAccountLabel.Text = "Зачислить на счёт";
                        Controls.Add(creditAccountComboBox);
                        break;
                    }
            }
        }

        private void debitAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
