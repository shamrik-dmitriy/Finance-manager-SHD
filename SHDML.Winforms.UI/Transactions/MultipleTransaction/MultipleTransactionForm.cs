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
        private string Title { get => Text; set { Text = value; } }
        private string TitleDefault { get; }

        public MultipleTransactionForm()
        {
            InitializeComponent();
            totalSumTransactionUserControl.IsEnabledSumField = false;
        }
        public MultipleTransactionForm(string typeTransactionOperations) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
        }

        private void addedTransactionButton_Click(object sender, EventArgs e)
        {
            var addedTransaction = new SingleTransaction.SingleTransactionForm("Добавить в чек транзакцию");
            if (addedTransaction.ShowDialog() == DialogResult.OK)
            {
                // TODO: Отправить данные в БД

                var newItem = new ItemOfMultipleTransaction(addedTransaction.SingleTransactionDTO.Name, addedTransaction.SingleTransactionDTO.Sum.ToString());
                newItem.DeleteItemFromReceipt += new EventHandler(DeleteTransaction);
                newItem.ChangeItemFromReceipt += new EventHandler(UpdateTransaction);
                ItemsFlowLayoutPanel.Controls.Add(newItem);

                totalSumTransactionUserControl.Sum += addedTransaction.SingleTransactionDTO.Sum;
            }
        }

        private void DeleteTransaction(object sender, EventArgs e)
        {
            var s = sender as ItemOfMultipleTransaction;
            totalSumTransactionUserControl.Sum -= s.Price;
            ItemsFlowLayoutPanel.Controls.Remove(s);
            this.Invalidate();
            this.Refresh();
            this.Update();
        }

        private void UpdateTransaction(object sender, EventArgs e)
        {
            var s = sender as ItemOfMultipleTransaction;
            var addedTransaction = new SingleTransaction.SingleTransactionForm();
            if (addedTransaction.ShowDialog() == DialogResult.OK)
            { 
            
                // TODO: Извлечь данные из БД, заполнить сигнлтранзакшн и открыть её
            }
        }

        private void accountInfoUserControl1_Load(object sender, EventArgs e)
        {
            accountInfoUserControl1.LabelOfTypeOperation = "Списать со счёта";

        }

        private void nameOfRetailertextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Title = string.IsNullOrWhiteSpace(textBox.Text) ? TitleDefault : TitleDefault + ": " + textBox.Text;

        }
    }
}
