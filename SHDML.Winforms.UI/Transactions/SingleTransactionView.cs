using System;
using System.Drawing;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using SHDML.BLL.DTO.DTO;
using SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls;
using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;

namespace SHDML.Winforms.UI.Transactions
{
    public partial class SingleTransactionView : Form, ISingleTransactionView
    {
        #region Private member variables

        private readonly EventAggregator _eventAggregator;

        #endregion

        #region Public events

        public event Action OnLoadView;
        public event EventHandler Add;
        public event Action<int> OnChangeTypeTransaction;

        #endregion

        #region Private properties

        private string Title
        {
            get => Text;
            set => Text = value;
        }

        private string TitleDefault { get; set; }

        #endregion

        #region Constructors

        public SingleTransactionView()
        {
            InitializeComponent();
        }

        public SingleTransactionView(EventAggregator eventAggregator) : this()
        {
            _eventAggregator = eventAggregator;
        }

        public SingleTransactionView(string typeTransactionOperations, EventAggregator eventAggregator) : this()
        {
            Title = typeTransactionOperations;
            TitleDefault = typeTransactionOperations;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Private methods

        private void ActionChangeTextBoxNameTransaction(OnChangeNameTransactionTextApplicationEvent obj)
        {
            Title = string.IsNullOrWhiteSpace(obj.Text) ? TitleDefault : TitleDefault + ": " + obj.Text;
        }

        private void AddSingleTransactionForm_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
            _eventAggregator.Subscribe<OnChangeNameTransactionTextApplicationEvent>(ActionChangeTextBoxNameTransaction);

            // _typeTransactionUcView.OnLoadUserControlView += TypeTransactionUserControlViewOnLoadUserControlView;
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

        #endregion

        protected internal SingleTransactionDTO SingleTransactionDTO { get; set; }

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

        public void AddIdentityUCView(IIdentityUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddAddCancelButtonsUserControl(IAddCancelButtonsUCView ucView)
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

        public void AddDescriptionTransactionUserControl(IDescriptionTextboxUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        public void AddNameTransactionUserControl(INameTextboxUCView ucView)
        {
            var typeTransactionUc = (UserControl)ucView;
            singleTransactionDesktopflowLayoutPanel.Controls.Add(typeTransactionUc);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Unsubscribe<OnChangeNameTransactionTextApplicationEvent>(
                ActionChangeTextBoxNameTransaction);
        }
    }
}