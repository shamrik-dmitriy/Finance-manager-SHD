using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.Button;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Additional
{
    public partial class ButtonUCView : UserControl, IButtonUCView
    {
        public ButtonUCView()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            button.Text = text;
        }
        
        public void SetVisible(bool visible)
        {
            button.Visible = visible;
        }
        
        public void SetEnabled(bool enable)
        {
            button.Enabled = enable;
        }
    }
}
