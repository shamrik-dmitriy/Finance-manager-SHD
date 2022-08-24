using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using SHDML.Winforms.UI.Transactions;
using SHDML.Winforms.UI.UserControls.Common;
using SHDML.Winforms.UI.UserControls.Wallet;

namespace SHDML.Winforms.UI
{
    public partial class MainView : Form, IMainView
    {
        public event Action OnLoadView;
        public event Action AddTransaction;
        public event Action AddAccount;

        private readonly EventAggregator _eventAggregator;

        public MainView(EventAggregator eventAggregator)
        {
            InitializeComponent();
            _eventAggregator = eventAggregator;
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction?.Invoke();
        }

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            new MultipleTransactionView("Добавить группу транзакций (чек)").ShowDialog();
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public void ShowDialog(string title)
        {
            base.Text = title;
            base.ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Dispose();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount?.Invoke();
        }

        public void AddAccountsSummaryUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            accoutsFlowLayoutPanel.Controls.Add(userControl);
        }

        public void SetAccountsData(IEnumerable<AccountDto> accountDtos)
        {
            accountActionAndTotalSumsplitContainer.Panel2.Controls.Add(
                new TotalSumInAccountsUCView(accountDtos.Sum(accountDto => accountDto.CurrentSum).ToString()));
        }

        private void closeInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseView();
        }
    }
}