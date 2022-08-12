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

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
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
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe<SelectedTypeOfTransactionApplicationEvent>(ActionSelectedTypeOfTransaction);
        }

        private void ActionSelectedTypeOfTransaction(SelectedTypeOfTransactionApplicationEvent obj)
        {
            TransactionType = obj.TypeOfTransaction;
            switch (TransactionType)
            {
                case 0:
                {
                    //_debitAccountInfoUcView.LabelOfTypeOperation = "Списать со счёта";
                    //_creditAccountInfoUcView.Visible = false;
                    break;
                }
                case 1:
                {
                    //_debitAccountInfoUcView.LabelOfTypeOperation = "Зачслить на счёт";
                    //_creditAccountInfoUcView.Visible = false;
                    break;
                }
                case 2:
                {
                    //_debitAccountInfoUcView.LabelOfTypeOperation = "Списать со счёта";
                    //_creditAccountInfoUcView.Visible = true;
                    break;
                }
            }

          //  financeInfoOfOperationflowLayoutPanel.Refresh();
          //  financeInfoOfOperationflowLayoutPanel.Update();
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

        public void AddAccountInfo(IAccountInfoUCView userControlView)
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