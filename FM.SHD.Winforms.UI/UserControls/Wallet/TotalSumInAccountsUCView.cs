using System.Windows.Forms;

namespace SHDML.Winforms.UI.UserControls.Wallet
{
    public partial class TotalSumInAccountsUCView : UserControl
    {
        public TotalSumInAccountsUCView(string sum)
        {
            InitializeComponent();
            SetText(sum);
        }

        public void SetText(string text)
        {
            labelTotalAccountsSum.Text = text;
        }
    }
}
