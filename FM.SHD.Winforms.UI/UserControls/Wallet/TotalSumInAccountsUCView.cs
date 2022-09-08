using System.Windows.Forms;

namespace FM.SHD.Winforms.UI.UserControls.Wallet
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
