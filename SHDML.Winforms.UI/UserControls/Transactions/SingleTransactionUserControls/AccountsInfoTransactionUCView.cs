using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHD.Presenters.UserControlPresenters;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class AccountsInfoTransactionUCView : UserControl, IAccountsInfoTransactionUCView
    {
        private readonly EventAggregator _eventAggregator;

        private int TransactionType { get; set; }


        public AccountsInfoTransactionUCView()
        {
            InitializeComponent();
        }

        public AccountsInfoTransactionUCView(EventAggregator eventAggregator) : this()
        {
        }

        public AccountsInfoTransactionUCView(int transactionType) : this()
        {
            TransactionType = transactionType;
        }

        public void SetAccounts(IEnumerable<AccountDto> getAll)
        {
        }

        public event Action OnLoadUserControlView;

        public void AddUserControl(IUserControlView userControlView)
        {
            financeInfoOfOperationflowLayoutPanel.Controls.Add((UserControl)userControlView);
        }

        private void AccountsInfoTransactionUCView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
        }
    }
}