using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.SharedInterfaces.Transactions.UserControl;

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
