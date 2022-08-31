using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Common;

namespace SHDML.Winforms.UI.UserControls.Common
{
    public partial class CheckboxUCView : UserControl, ICheckboxUCView
    {
        public CheckboxUCView()
        {
            InitializeComponent();
        }

        public bool GetCheckboxState()
        {
            return checkBox1.Checked;
        }

        public void SetText(string text)
        {
            checkBox1.Text = text;
        }
    }
}