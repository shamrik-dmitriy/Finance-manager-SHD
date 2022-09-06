using System;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Winforms.UI.UserControls.Wallet
{
    public partial class AccountSummaryUCView : UserControl, IAccountSummaryUCView
    {
        private AccountDto AccountDto { get; set; }

        public AccountSummaryUCView()
        {
            InitializeComponent();
        }

        public event Action<AccountDto> UpdateAccount;

        public void SetData(AccountDto accountDto)
        {
            AccountDto = accountDto;
            accountNameLabel.Text = AccountDto.Name;
            accountSumLabel.Text = AccountDto.CurrentSum.ToString();
        }

        private void account_Click(object sender, EventArgs e)
        {
            UpdateAccount?.Invoke(AccountDto);
        }
    }
}