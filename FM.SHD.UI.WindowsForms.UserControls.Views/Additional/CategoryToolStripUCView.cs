using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Additional
{
    public partial class CategoryToolStripUCView : UserControl
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
    }
}
