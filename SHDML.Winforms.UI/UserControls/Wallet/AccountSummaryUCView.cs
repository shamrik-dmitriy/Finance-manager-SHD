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

namespace SHDML.Winforms.UI.UserControls.Wallet
{
    public partial class AccountSummaryUCView : UserControl, IAccountSummaryUCView
    {
        private long Id { get; }

        public AccountSummaryUCView()
        {
            InitializeComponent();
        }

        public AccountSummaryUCView(AccountDto accountDto) : this()
        {
            Id = accountDto.Id;
            SetData(accountDto);
        }

        public event Action<long> UpdateAccount;

        public void SetData(AccountDto accountDto)
        {
            accountNameLabel.Text = accountDto.Name;
            accountSumLabel.Text = accountDto.CurrentSum.ToString();
        }

        private void account_Click(object sender, EventArgs e)
        {
            UpdateAccount?.Invoke(Id);
        }
    }
}