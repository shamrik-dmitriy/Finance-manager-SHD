using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.IntrefacesViews;
using FM.SHD.Presenters.IntrefacesViews.UserControl;
using FM.SHD.Presenters.IntrefacesViews.UserControl.Wallet;
using FM.SHDML.Core.Models.AccountModel;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Dtos.UIDto;
using SHDML.Winforms.UI.UserControls.Common;
using SHDML.Winforms.UI.UserControls.Wallet;
using SHDML.Winforms.UI.Views.Transactions;

namespace SHDML.Winforms.UI
{
    public partial class MainView : Form, IMainView
    {
        public event Action OnLoadView;
        public event Action AddTransaction;
        public event Action AddAccount;

        public event Action<string> OpenDataFile;

        private readonly EventAggregator _eventAggregator;

        public MainView(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            InitializeComponent();
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction?.Invoke();
        }

        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            new MultipleTransactionView("Добавить группу транзакций (чек)").ShowDialog();
        }

        public new void ShowDialog()
        {
            base.ShowDialog();
        }

        public void ShowDialog(string title)
        {
            base.Text = title;
            base.ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            OnLoadView?.Invoke();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _eventAggregator.Dispose();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount?.Invoke();
        }

        public void AddAccountsSummaryUserControl(IUserControlView userControlView)
        {
            var userControl = (UserControl)userControlView;
            accoutsFlowLayoutPanel.Controls.Add(userControl);
        }

        public void SetAccountsData(IEnumerable<AccountDto> accountDtos)
        {
            accountActionAndTotalSumsplitContainer.Panel2.Controls.Add(
                new TotalSumInAccountsUCView(accountDtos.Sum(accountDto => accountDto.CurrentSum).ToString()));
        }

        public void SetViewOnUnActiveUI()
        {
            splitContainerDesktop.Visible = false;

            foreach (ToolStripItem menuStrip1Item in menuStrip1.Items)
            {
                switch (menuStrip1Item.Name)
                {
                    case "toolStripMenuItemOpenDataFile":
                    case "quitToolStripMenuItem":
                    case "файлToolStripMenuItem":
                    {
                        menuStrip1Item.Enabled = true;
                        break;
                    }
                    default:
                    {
                        menuStrip1Item.Enabled = false;
                        break;
                    }
                }
            }
        }
        
        public void SetViewOnActiveUI()
        {
            splitContainerDesktop.Visible = true;

            foreach (ToolStripItem menuStrip1Item in menuStrip1.Items)
            {
                switch (menuStrip1Item.Name)
                {
                    case "toolStripMenuItemOpenDataFile":
                    case "quitToolStripMenuItem":
                    case "файлToolStripMenuItem":
                    {
                        menuStrip1Item.Enabled = true;
                        break;
                    }
                    default:
                    {
                        menuStrip1Item.Enabled = false;
                        break;
                    }
                }
            }
        }

        public void AddElementInRecentOpenItems(List<RecentOpenFilesDto> recentOpenFiles)
        {
            var baseOpenDropDownItems = new List<ToolStripItem>();
            if (recentOpenFiles.Count > 0)
            {
                baseOpenDropDownItems.Add(toolStripMenuItemOpenDataFile.DropDownItems[0]);
                baseOpenDropDownItems.Add(new ToolStripSeparator());
            }

            toolStripMenuItemOpenDataFile.DropDownItems.Clear();

            baseOpenDropDownItems.AddRange(recentOpenFiles.Select(recentOpenDto =>
                new ToolStripMenuItem(recentOpenDto.FileName, null, OnClickLoadDataFile)
                    { ToolTipText = recentOpenDto.FilePath, AutoToolTip = true, }));

            toolStripMenuItemOpenDataFile.DropDownItems.AddRange(baseOpenDropDownItems.ToArray());
        }

        private void OnClickLoadDataFile(object sender, EventArgs e)
        {
            var filePath = ((ToolStripMenuItem)sender).ToolTipText;
            OpenDataFile?.Invoke(filePath);
        }

        public void SetViewOnCompleteLoadData()
        {
            splitContainerDesktop.Visible = true;

            foreach (ToolStripItem menuStrip1Item in menuStrip1.Items)
            {
                menuStrip1Item.Enabled = true;
            }
        }

        private void closeInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseView();
        }

        private void toolStripMenuItemOpenDataFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
            };
            openFileDialog.ShowDialog();
            OpenDataFile?.Invoke(openFileDialog.FileName);
        }
    }
}