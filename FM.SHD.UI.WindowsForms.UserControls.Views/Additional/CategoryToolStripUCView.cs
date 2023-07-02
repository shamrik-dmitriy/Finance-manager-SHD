using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Category.ToolStripDropDownButtonCategory;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Additional
{
    public partial class CategoryToolStripUCView : UserControl, ICategoryToolStripUCView
    {
        public CategoryToolStripUCView()
        {
            InitializeComponent();
            toolStripDropDownButtonCategories.Dock = DockStyle.Fill;

        }

        public void SetText(string text)
        {
            toolStripDropDownButtonCategories.Text = text;
        }

        public event Action OnLoadUserControlView;
        public event Action ClickUserControlView;
        public void SetLabelText(string text)
        {
            categoriesLabel.Text = text;
        }

        public long? GetCategoryId()
        {
            throw new NotImplementedException();
        }

        public BaseDto GetCategoryDto()
        {
            throw new NotImplementedException();
        }

        public void SetDataSource(IEnumerable<BaseDto> value)
        {
            throw new NotImplementedException();
        }

        public void SetCategoryId(long? id)
        {
            throw new NotImplementedException();
        }

        public void SetCategoryFirst()
        {
            throw new NotImplementedException();
        }
    }
}
