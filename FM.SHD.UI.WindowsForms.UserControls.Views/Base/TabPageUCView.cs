using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Base
{
    public partial class TabPageUCView : UserControl, ITabPageUCView
    {
        public TabPageUCView()
        {
            InitializeComponent();
        }

        public void AddUserControlToButtonBlock(UserControl userControl)
        {
            splitContainerDesktop.Panel1.Controls[0].Controls.Add(userControl);
        }
        
        public void AddUserControlToWorkspaceBlock(UserControl userControl)
        {
            splitContainerDesktop.Panel2.Controls.Add(userControl);
        }
    }
}
