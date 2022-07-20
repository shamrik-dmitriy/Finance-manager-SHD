using SHDML.BLL.DTO.DTO;
using SHDML.Winforms.UI.Transactions.MultipleTransaction;
using SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHDML.Winforms.UI.Transactions.SingleTransaction
{
    public partial class SingleTransactionForm : Form
    {
        private string Title { get => Text; set { Text = value; } }
        private string TitleDefault { get; }

        public SingleTransactionForm()
        {
            InitializeComponent();
        }
        protected internal SingleTransactionDTO SingleTransactionDTO { get; set; }

        public SingleTransactionForm(string typeTransactionOperations) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            if (SingleTransactionDTO != null)
            {

            }
            else
            {
                selectTypeTransactionUserControl.TypeOperationSelectedIndexChanged += new EventHandler(SelectTypeTransaction_SelectedIndexChanged);
                selectTypeTransactionUserControl.typeOperationsCombobox.SelectedIndex = 0;
            }
        }

        protected void SelectTypeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (SelectTypeTransactionUserControl)sender;
            billingInfoFlowLayoutPanel.Controls.Clear();
            switch (s.typeOperationsCombobox.SelectedIndex)
            {
                case 0:
                    {
                        billingInfoFlowLayoutPanel.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
                case 1:
                    {
                        billingInfoFlowLayoutPanel.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
                case 2:
                    {
                        billingInfoFlowLayoutPanel.Controls.Add(new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                        break;
                    }
            }
            billingInfoFlowLayoutPanel.Refresh();
            billingInfoFlowLayoutPanel.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            Title = string.IsNullOrWhiteSpace(textBox.Text) ? TitleDefault : TitleDefault + ": " + textBox.Text;
        }

        private void addedSingleTransactionButton_Click(object sender, EventArgs e)
        {

            var t = billingInfoFlowLayoutPanel.Controls[0] as SelectAccountUserControl;
            SingleTransactionDTO = new SingleTransactionDTO
            {
                Name = nameTransactiontextBox.Text,
                Description = descriptionTransactiontextBox.Text,
                Sum = t.Sum
            };
            // TODO: Отправить данные в БД
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
