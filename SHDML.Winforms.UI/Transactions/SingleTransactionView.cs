using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews;
using SHDML.BLL.DTO.DTO;
using SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls;

namespace SHDML.Winforms.UI.Transactions
{
    public partial class SingleTransactionView : Form, ISingleTransactionView
    {
        public event EventHandler Add;

        private string Title
        {
            get => Text;
            set => Text = value;
        }

        private string TitleDefault { get; set; }

        public SingleTransactionView()
        {
            InitializeComponent();
        }

        protected internal SingleTransactionDTO SingleTransactionDTO { get; set; }

        public SingleTransactionView(string typeTransactionOperations) : this()
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
                selectTypeTransactionUserControl.TypeOperationSelectedIndexChanged +=
                    new EventHandler(SelectTypeTransaction_SelectedIndexChanged);
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
                    billingInfoFlowLayoutPanel.Controls.Add(
                        new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                    break;
                }
                case 1:
                {
                    billingInfoFlowLayoutPanel.Controls.Add(
                        new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
                    break;
                }
                case 2:
                {
                    billingInfoFlowLayoutPanel.Controls.Add(
                        new SelectAccountUserControl(s.typeOperationsCombobox.SelectedIndex));
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
            Add?.Invoke(sender, e);

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

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public void ShowDialog(string title)
        {
            Title = title;
            TitleDefault = title;

            base.ShowDialog();
        }

        public SingleTransactionDTO GetTransactionInfo()
        {
            var accountUser = billingInfoFlowLayoutPanel.Controls[0] as SelectAccountUserControl;
            
            return SingleTransactionDTO = new SingleTransactionDTO
            {
                TypeTransaction = selectTypeTransactionUserControl.Transaction,
                Name = nameTransactiontextBox.Text,
                Description = descriptionTransactiontextBox.Text,
                Sum = accountUser.Sum,
                DebitAccount = accountUser.DebitAccount,
                CreditAccount = accountUser.CreditAccount,
                Category = selectCategoryUserControl.CategoryName,
                Date = accountUser.Date + accountUser.Time,
                Contragent = selectContrAgentUserControl.ContragentName,
                FamilyMember = selectFamilyMemberUserControl.FamilyMemberName
            };
        }
    }
}