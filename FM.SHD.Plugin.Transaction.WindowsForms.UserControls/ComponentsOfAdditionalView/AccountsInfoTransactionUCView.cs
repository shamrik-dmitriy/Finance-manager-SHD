using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfAdditionalView
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

        #region UI

        public void AddDate(IDateTransactionUCView userControlView)
        {
            financeInfoOfOperationflowLayoutPanel.Controls.Add((UserControl)userControlView);
        }

        public void AddAccountInfo(ICategoryUCView userControlView)
        {
            financeInfoOfOperationflowLayoutPanel.Controls.Add((UserControl)userControlView);
        }

        public void AddSumm(ISumTransactionUCView userControlView)
        {
            financeInfoOfOperationflowLayoutPanel.Controls.Add((UserControl)userControlView);
        }

        #endregion

        private void AccountsInfoTransactionUCView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
        }
    }
}