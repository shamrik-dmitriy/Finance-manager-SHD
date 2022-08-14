using System.ComponentModel;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

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

        public string Name { get => accountComboBox.Text; set => accountComboBox.Text = value; }

        public AccountInfoUCView()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            LabelOfTypeOperation = text;
        }

        public void SetVisible(bool visible)
        {
           Visible = visible;
        }
    }
}
