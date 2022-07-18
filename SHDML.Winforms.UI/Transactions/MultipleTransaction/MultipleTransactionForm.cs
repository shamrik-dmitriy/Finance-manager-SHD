using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.MultipleTransaction
{
    public partial class MultipleTransactionForm : Form
    {
        public MultipleTransactionForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addedTransactionButton_Click(object sender, EventArgs e)
        {
            new SingleTransaction.SingleTransactionForm("Добавить в чек транзакцию").ShowDialog();
            ItemsFlowLayoutPanel.Controls.Add(new ItemOfMultipleTransaction());
        }

        private void accountInfoUserControl1_Load(object sender, EventArgs e)
        {
            accountInfoUserControl1.LabelOfTypeOperation = "Списать со счёта";

        }
    }
}
