using System.Collections.Generic;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Transactions;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class CategoryUCView : UserControl, ICategoryTransactionUCView
    {
        public string CategoryName { get => comboBoxCategoryName.Text; set => comboBoxCategoryName.Text = value; }

        public CategoryUCView()
        {
            InitializeComponent();
        }      
        
        public CategoryUCView(string labelText):this()
        {
            label.Text = labelText;
        }


        public void SetDataSource(IEnumerable<string> data)
        {
            
        }
    }
}
