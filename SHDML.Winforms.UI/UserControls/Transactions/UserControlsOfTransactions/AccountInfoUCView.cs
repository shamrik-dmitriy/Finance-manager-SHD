using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;
using FM.SHDML.Core.Models.AccountModel;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class AccountInfoUCView : UserControl, IAccountInfoUCView
    {
        [Browsable(true)]
        [Category("Property")]
        [Description("Изменяет текст лейбла рядом с элементов выбора")]
        public string LabelOfTypeOperation
        {
            get { return accountLabel.Text; }
            set { accountLabel.Text = value; }
        }

        public string Name
        {
            get => accountComboBox.Text;
            set => accountComboBox.Text = value;
        }

        public AccountInfoUCView()
        {
            InitializeComponent();
        }

        public event Action OnLoadUserControlView;

        public void SetText(string text)
        {
            LabelOfTypeOperation = text;
        }

        public void SetVisible(bool visible)
        {
            Visible = visible;
        }

        public void SetAccounts(IEnumerable<AccountDto> allAccounts)
        {
            accountComboBox.Items.AddRange(allAccounts.Select(x => x.Name).ToArray());
        }

        private void AccountsUserControlView_Load(object sender, EventArgs e)
        {
            OnLoadUserControlView?.Invoke();
            SetAccount(0);
        }

        private void SetAccount(int i)
        {
            accountComboBox.SelectedIndex = i;
        }
    }
}