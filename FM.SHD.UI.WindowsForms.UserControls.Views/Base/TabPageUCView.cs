using System;
using System.Windows.Forms;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.TabPage;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;

namespace FM.SHD.UI.WindowsForms.UserControls.Views.Base
{
    public partial class TabPageUCView : UserControl, ITabPageUCView
    {

        public TabPageUCView()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void AddUserControlToButtonBlock(UserControl userControl)
        {
            splitContainerDesktop.Panel1.Controls.Add(userControl);
            Refresh();
        }
        
        public void AddUserControlToWorkspaceBlock(UserControl userControl)
        {
            splitContainerDesktop.Panel2.Controls.Add(userControl);
            Refresh();
        }   
        
        public void AddUserControlToWorkspaceBlock(IUserControlView userControl)
        {
            splitContainerDesktop.Panel2.Controls.Add((UserControl)userControl);
            Refresh();
        }

        private void buttonAddReceipt_Click(object sender, System.EventArgs e)
        {

        }

        public event Action OnLoad;

        private void TabPageUCView_Load(object sender, EventArgs e)
        {
            OnLoad?.Invoke();
        }
    }
}
