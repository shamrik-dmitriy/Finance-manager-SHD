﻿using System.Windows.Forms;

namespace FM.SHD.Plugins.Shared.UI
{
    public partial class TabPageContent : UserControl
    {
        public TabPageContent()
        {
            InitializeComponent();
        }

        public void AddUserControlToButtonBlock(UserControl userControl)
        {
            splitContainerDesktop.Panel1.Controls.Add(userControl);
            
        }
        
        public void AddUserControlToWorkspaceBlock(UserControl userControl)
        {
            splitContainerDesktop.Controls.Add(userControl);
        }
    }
}
