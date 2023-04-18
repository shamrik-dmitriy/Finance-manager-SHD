﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FM.SHD.Infrastructure.Events;
using FM.SHD.Presenters.IntrefacesViews.Views;
using FM.SHD.UI.WindowsForms.UserControls.Presenters.UIInterfaces;
using FM.SHD.Winforms.UI.UserControls.Wallet;
using FM.SHDML.Core.Models.Dtos;
using FM.SHDML.Core.Models.Dtos.UIDto;

namespace FM.SHD.Winforms.UI
{
    public partial class MainBaseView : Form, IMainBaseView
    {
        public event Action OnLoadView;
        public event Action AddingAccount;

        public event Action<string> OpeningDataFile;
        public event Action<string> CreatingDataFile;

        private readonly EventAggregator _eventAggregator;

        private readonly ApplicationContext _context;

        public MainBaseView(ApplicationContext applicationContext)
        {
            _context = applicationContext;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public void AddUserControl(IUserControlView userControlView)
        {
            //TODO: Пересмотреть функционал этого метода
        }

        public void AddHorizontalLine()
        {
            throw new NotImplementedException();
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
            // _eventAggregator.Dispose();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddingAccount?.Invoke();
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

        public void SetVisibleUserLoginInfo(bool isVisible)
        {
            if (isVisible)
            {
                splitContainerLeftSideBar.Panel1.Visible = true;
            }
            else
            {
                splitContainerLeftSideBar.Panel1.Visible = false;
                splitContainerLeftSideBar.Panel1MinSize = 0;
                splitContainerLeftSideBar.SplitterDistance = 0;
            }
        }

        public void ClearAccountsSummaryUserControls()
        {
            accoutsFlowLayoutPanel.Controls.Clear();
        }

        public void AddTab(TabPage tabPage)
        {
            tabControl1.TabPages.Add(tabPage);
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
            OpeningDataFile?.Invoke(filePath);
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
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            OpeningDataFile?.Invoke(openFileDialog.FileName);
        }

        private void toolStripMenuItemCreateDataFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Title = "Создать новую БД",
                DefaultExt = ".fmshd",
                SupportMultiDottedExtensions = true,
                Filter = "Файл БД | *.fmshd",
                FilterIndex = 1
            };
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            CreatingDataFile?.Invoke(saveFileDialog.FileName);
            MessageBox.Show($"Файл {saveFileDialog.FileName} успешно сохранён");
        }
    }
}