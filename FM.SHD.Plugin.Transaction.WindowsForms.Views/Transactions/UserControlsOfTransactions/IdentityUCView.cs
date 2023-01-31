using System.Windows.Forms;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions.UserControlsOfTransactions
{
    public partial class IdentityUCView : UserControl, IIdentityUCView
    {
        public string FamilyMemberName { get => comboBoxFamilyMemberName.Text; set => comboBoxFamilyMemberName.Text = value; }
        
        public IdentityUCView()
        {
            InitializeComponent();
        }
    }
}
