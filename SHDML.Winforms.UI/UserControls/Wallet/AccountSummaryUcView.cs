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
    public partial class AccountSummaryUcView : UserControl, IAccountSummaryUCView
    {
        public AccountSummaryUcView(AccountDto accountDto)
        {
            InitializeComponent();
            SetData(accountDto);
        }

        private void SetData(AccountDto accountDto)
        {
            accountNameLabel.Text = accountDto.Name;
            accountSumLabel.Text = accountDto.CurrentSum.ToString();
        }


        private void account_Click(object sender, EventArgs e)
        {
        }
    }
}