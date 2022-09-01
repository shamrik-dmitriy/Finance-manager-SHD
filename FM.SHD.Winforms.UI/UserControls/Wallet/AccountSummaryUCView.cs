using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;

namespace SHDML.Winforms.UI.UserControls.Wallet
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