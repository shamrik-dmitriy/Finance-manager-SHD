﻿using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using SHDML.BLL.DTO.DTO;
using SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls;

namespace SHDML.Winforms.UI.Transactions
{
    public partial class SingleTransactionView : Form, ISingleTransactionView
    {
        private readonly EventAggregator _eventAggregator;
        public event Action OnLoadEventrsss;
        public event EventHandler Add;
        public event Action<int> OnChangeTypeTransaction;

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

        public SingleTransactionView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        protected internal SingleTransactionDTO SingleTransactionDTO { get; set; }

        public SingleTransactionView(string typeTransactionOperations, EventAggregator eventAggregator) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
            _eventAggregator = eventAggregator;
        }

        private void ActionChangeTextBoxNameTransaction(ChangeTextBoxNameTransactionText obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            OnLoadEventrsss?.Invoke();
            _eventAggregator.Subscribe<ChangeTextBoxNameTransactionText>(ActionChangeTextBoxNameTransaction);

            // _typeTransactionUcView.LoadUserControlView += TypeTransactionUserControlViewOnLoadUserControlView;
            /*
            if (SingleTransactionDTO != null)
            {
            }
            else
            {
                selectTypeTransactionUserControl.TypeOperationSelectedIndexChanged +=
                    new EventHandler(SelectTypeTransaction_SelectedIndexChanged);
                selectTypeTransactionUserControl.typeOperationsCombobox.SelectedIndex = 0;
            }*/
        }

        protected void SelectTypeTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChangeTypeTransaction?.Invoke(((TypeTransactionUCView)sender).typeOperationsCombobox
                .SelectedIndex);
            /*  
               switch (s.typeOperationsCombobox.SelectedIndex)
               {
                   case 0:
                   {
                           BillingAccountsInfoTransactionInfo.
   
                       billingInfoFlowLayoutPanel.Controls.Add(
                           new AccountsInfoTransactionUCView(s.typeOperationsCombobox.SelectedIndex));
                       break;
                   }
                   case 1:
                   {
                       billingInfoFlowLayoutPanel.Controls.Add(
                           new AccountsInfoTransactionUCView(s.typeOperationsCombobox.SelectedIndex));
                       break;
                   }
                   case 2:
                   {
                       billingInfoFlowLayoutPanel.Controls.Add(
                           new AccountsInfoTransactionUCView(s.typeOperationsCombobox.SelectedIndex));
                       break;
                   }
               }
   
               billingInfoFlowLayoutPanel.Refresh();
               billingInfoFlowLayoutPanel.Update();
   
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
               */
        }

        private void addedSingleTransactionButton_Click(object sender, EventArgs e)
        {
            Add?.Invoke(sender, e);

            /*var t = billingInfoFlowLayoutPanel.Controls[0] as AccountsInfoTransactionUCView;
            SingleTransactionDTO = new SingleTransactionDTO
            {
                Name = nameTransactiontextBox.Text,
                Description = descriptionTransactiontextBox.Text,
                Sum = t.Sum
            };
            // TODO: Отправить данные в БД
            */
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
            return new SingleTransactionDTO();
            /*
            var accountUser = billingInfoFlowLayoutPanel.Controls[0] as AccountsInfoTransactionUCView;
            
            return SingleTransactionDTO = new SingleTransactionDTO
            {
                TypeTransaction = selectTypeTransactionUserControl.Transaction,
                Name = nameTransactiontextBox.Text,
                Description = descriptionTransactiontextBox.Text,
                Sum = accountUser.Sum,
                DebitAccount = accountUser.DebitAccount,
                CreditAccount = accountUser.CreditAccount,
                Category = _categoryTransactionUcView.CategoryName,
                Date = accountUser.Date + accountUser.Time,
                Contragent = _contrAgentUcView.ContragentName,
                FamilyMember = _familyMemberUcView.FamilyMemberName
            };*/
        }

        public void AddCategoryTransactionUserControl(ICategoryTransactionUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddAddCancelButtonsUserControl(IAddCancelButtonsUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddFamilyMemberUserControl(IFamilyMemberUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddContrAgentUserControl(IContrAgentUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddTypeTransactionUserControl(ITypeTransactionUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddHorizontalLine()
        {
            singleTransactionDesktopflowLayoutPanel.Controls.Add(new Label()
                { BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top, Size = new Size(359, 2) });
        }

        public void AddAccountsInfoTransactionUserControl(IAccountsInfoTransactionUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddDescriptionTransactionUserControl(IDescriptionTransactionUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddNameTransactionUserControl(INameTransactionUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        private void singleTransactionDesktopflowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void selectTypeTransactionUserControl_Load(object sender, EventArgs e)
        {
        }

        public void SetVisibleCreditAccout(bool isVisible)
        {
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            // _eventAggregator.Unsubscribe<SelectedTypeOfTransactionApplicationEvent>(ActionSelectedTypeOfTransaction);
            _eventAggregator.Unsubscribe<ChangeTextBoxNameTransactionText>(ActionChangeTextBoxNameTransaction);
        }
    }
}