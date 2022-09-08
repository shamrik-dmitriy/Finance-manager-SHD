using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Winforms.UI.UserControls.Transactions.TransactionUserControls
{
    public partial class AccountsInfoTransactionUCView : UserControl, IAccountsInfoTransactionUCView
    {
        private readonly EventAggregator _eventAggregator;


        //public decimal Sum => _sumTransactionUcView.Sum;

        private int TransactionType { get; set; }

        //public string DebitAccount
        //{
        //    get => _debitAccountInfoUcView.Name;
        //    set => _debitAccountInfoUcView.Name = value;
        //}

        //public string CreditAccount
        //{
        //   get => _creditAccountInfoUcView.Name;
        //    set => _creditAccountInfoUcView.Name = value;
        //}

        //public DateTime Date
        //{
        //   get => _dateTransactionUcView.Date;
        //    set => _dateTransactionUcView.Date = value;
        //}

        //public TimeSpan Time
        //{
        //    get => _dateTransactionUcView.Time;
        //    set => _dateTransactionUcView.Time = value;
        //}

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