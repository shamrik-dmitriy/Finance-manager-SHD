using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    public partial class FamilyMemberUCView : UserControl, IFamilyMemberUCView
    {
        public string FamilyMemberName { get => comboBoxFamilyMemberName.Text; set => comboBoxFamilyMemberName.Text = value; }
        
        public FamilyMemberUCView()
        {
            InitializeComponent();
        }
    }
}
