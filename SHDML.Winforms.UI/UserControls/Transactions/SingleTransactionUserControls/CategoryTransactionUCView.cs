using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    public partial class CategoryTransactionUCView : UserControl, ICategoryTransactionUCView
    {
        public string CategoryName { get => comboBoxCategoryName.Text; set => comboBoxCategoryName.Text = value; }
        public CategoryTransactionUCView()
        {
            InitializeComponent();
        }
    }
}
