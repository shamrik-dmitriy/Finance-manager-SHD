
using FM.SHD.Winforms.UI.UserControls.Login;

namespace FM.SHD.Winforms.UI
{
	partial class MainBaseView
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreateDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ваToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerDesktop = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftSideBar = new System.Windows.Forms.SplitContainer();
            this.loginucView1 = new FM.SHD.Winforms.UI.UserControls.Login.LoginUCView();
            this.splitContainerWallet = new System.Windows.Forms.SplitContainer();
            this.accountActionAndTotalSumsplitContainer = new System.Windows.Forms.SplitContainer();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accoutsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).BeginInit();
            this.splitContainerDesktop.Panel1.SuspendLayout();
            this.splitContainerDesktop.Panel2.SuspendLayout();
            this.splitContainerDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftSideBar)).BeginInit();
            this.splitContainerLeftSideBar.Panel1.SuspendLayout();
            this.splitContainerLeftSideBar.Panel2.SuspendLayout();
            this.splitContainerLeftSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWallet)).BeginInit();
            this.splitContainerWallet.Panel1.SuspendLayout();
            this.splitContainerWallet.Panel2.SuspendLayout();
            this.splitContainerWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountActionAndTotalSumsplitContainer)).BeginInit();
            this.accountActionAndTotalSumsplitContainer.Panel1.SuspendLayout();
            this.accountActionAndTotalSumsplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.пToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCreateDataFile,
            this.toolStripMenuItemOpenDataFile,
            this.сохранитьToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.ваToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.файлToolStripMenuItem.Image = global::FM.SHD.Winforms.UI.Properties.Resources.free_icon_font_file_invoice_dollar_7928219;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItemCreateDataFile
            // 
            this.toolStripMenuItemCreateDataFile.Image = global::FM.SHD.Winforms.UI.Properties.Resources.free_icon_font_add_document_3914213;
            this.toolStripMenuItemCreateDataFile.Name = "toolStripMenuItemCreateDataFile";
            this.toolStripMenuItemCreateDataFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCreateDataFile.Text = "Создать";
            this.toolStripMenuItemCreateDataFile.Click += new System.EventHandler(this.toolStripMenuItemCreateDataFile_Click);
            // 
            // toolStripMenuItemOpenDataFile
            // 
            this.toolStripMenuItemOpenDataFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.toolStripMenuItemOpenDataFile.Image = global::FM.SHD.Winforms.UI.Properties.Resources.free_icon_font_folder_upload_7653219;
            this.toolStripMenuItemOpenDataFile.Name = "toolStripMenuItemOpenDataFile";
            this.toolStripMenuItemOpenDataFile.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpenDataFile.Text = "Открыть";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemOpenDataFile_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Image = global::FM.SHD.Winforms.UI.Properties.Resources.free_icon_font_settings_sliders_3917103;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Visible = false;
            // 
            // ваToolStripMenuItem
            // 
            this.ваToolStripMenuItem.Name = "ваToolStripMenuItem";
            this.ваToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Выйти";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.closeInToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.калькуляторToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Visible = false;
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            // 
            // пToolStripMenuItem
            // 
            this.пToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.toolStripSeparator1,
            this.оПрограммеToolStripMenuItem});
            this.пToolStripMenuItem.Name = "пToolStripMenuItem";
            this.пToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.пToolStripMenuItem.Text = "Помощь";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // splitContainerDesktop
            // 
            this.splitContainerDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDesktop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerDesktop.IsSplitterFixed = true;
            this.splitContainerDesktop.Location = new System.Drawing.Point(0, 24);
            this.splitContainerDesktop.Name = "splitContainerDesktop";
            // 
            // splitContainerDesktop.Panel1
            // 
            this.splitContainerDesktop.Panel1.Controls.Add(this.splitContainerLeftSideBar);
            // 
            // splitContainerDesktop.Panel2
            // 
            this.splitContainerDesktop.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerDesktop.Size = new System.Drawing.Size(1208, 603);
            this.splitContainerDesktop.SplitterDistance = 335;
            this.splitContainerDesktop.TabIndex = 2;
            // 
            // splitContainerLeftSideBar
            // 
            this.splitContainerLeftSideBar.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerLeftSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftSideBar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftSideBar.IsSplitterFixed = true;
            this.splitContainerLeftSideBar.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftSideBar.Name = "splitContainerLeftSideBar";
            this.splitContainerLeftSideBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeftSideBar.Panel1
            // 
            this.splitContainerLeftSideBar.Panel1.Controls.Add(this.loginucView1);
            this.splitContainerLeftSideBar.Panel1MinSize = 70;
            // 
            // splitContainerLeftSideBar.Panel2
            // 
            this.splitContainerLeftSideBar.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerLeftSideBar.Panel2.Controls.Add(this.splitContainerWallet);
            this.splitContainerLeftSideBar.Size = new System.Drawing.Size(335, 603);
            this.splitContainerLeftSideBar.SplitterDistance = 77;
            this.splitContainerLeftSideBar.TabIndex = 0;
            // 
            // loginucView1
            // 
            this.loginucView1.AutoSize = true;
            this.loginucView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginucView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginucView1.Location = new System.Drawing.Point(0, 0);
            this.loginucView1.MinimumSize = new System.Drawing.Size(309, 70);
            this.loginucView1.Name = "loginucView1";
            this.loginucView1.Size = new System.Drawing.Size(335, 77);
            this.loginucView1.TabIndex = 0;
            // 
            // splitContainerWallet
            // 
            this.splitContainerWallet.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWallet.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerWallet.IsSplitterFixed = true;
            this.splitContainerWallet.Location = new System.Drawing.Point(0, 0);
            this.splitContainerWallet.Name = "splitContainerWallet";
            this.splitContainerWallet.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWallet.Panel1
            // 
            this.splitContainerWallet.Panel1.Controls.Add(this.accountActionAndTotalSumsplitContainer);
            // 
            // splitContainerWallet.Panel2
            // 
            this.splitContainerWallet.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerWallet.Panel2.Controls.Add(this.accoutsFlowLayoutPanel);
            this.splitContainerWallet.Size = new System.Drawing.Size(335, 522);
            this.splitContainerWallet.SplitterDistance = 94;
            this.splitContainerWallet.SplitterWidth = 1;
            this.splitContainerWallet.TabIndex = 1;
            // 
            // accountActionAndTotalSumsplitContainer
            // 
            this.accountActionAndTotalSumsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountActionAndTotalSumsplitContainer.Location = new System.Drawing.Point(0, 0);
            this.accountActionAndTotalSumsplitContainer.Name = "accountActionAndTotalSumsplitContainer";
            this.accountActionAndTotalSumsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // accountActionAndTotalSumsplitContainer.Panel1
            // 
            this.accountActionAndTotalSumsplitContainer.Panel1.Controls.Add(this.addAccountButton);
            this.accountActionAndTotalSumsplitContainer.Size = new System.Drawing.Size(335, 94);
            this.accountActionAndTotalSumsplitContainer.SplitterDistance = 32;
            this.accountActionAndTotalSumsplitContainer.TabIndex = 0;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAccountButton.Location = new System.Drawing.Point(0, 0);
            this.addAccountButton.MaximumSize = new System.Drawing.Size(319, 31);
            this.addAccountButton.MinimumSize = new System.Drawing.Size(319, 31);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(319, 31);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Добавить счёт";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // accoutsFlowLayoutPanel
            // 
            this.accoutsFlowLayoutPanel.AutoScroll = true;
            this.accoutsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.accoutsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accoutsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.accoutsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.accoutsFlowLayoutPanel.Name = "accoutsFlowLayoutPanel";
            this.accoutsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.accoutsFlowLayoutPanel.Size = new System.Drawing.Size(335, 427);
            this.accoutsFlowLayoutPanel.TabIndex = 0;
            this.accoutsFlowLayoutPanel.WrapContents = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // MainBaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 627);
            this.Controls.Add(this.splitContainerDesktop);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainBaseView";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerDesktop.Panel1.ResumeLayout(false);
            this.splitContainerDesktop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).EndInit();
            this.splitContainerDesktop.ResumeLayout(false);
            this.splitContainerLeftSideBar.Panel1.ResumeLayout(false);
            this.splitContainerLeftSideBar.Panel1.PerformLayout();
            this.splitContainerLeftSideBar.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftSideBar)).EndInit();
            this.splitContainerLeftSideBar.ResumeLayout(false);
            this.splitContainerWallet.Panel1.ResumeLayout(false);
            this.splitContainerWallet.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWallet)).EndInit();
            this.splitContainerWallet.ResumeLayout(false);
            this.accountActionAndTotalSumsplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountActionAndTotalSumsplitContainer)).EndInit();
            this.accountActionAndTotalSumsplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private UserControls.Wallet.TotalSumInAccountsUCView _inAccountInfo1;
        private UserControls.Wallet.TotalSumInAccountsUCView _totalSumInAccountsInfoucView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCreateDataFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenDataFile;
        private System.Windows.Forms.ToolStripSeparator сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerDesktop;
        private System.Windows.Forms.SplitContainer splitContainerLeftSideBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainerWallet;
        private System.Windows.Forms.SplitContainer accountActionAndTotalSumsplitContainer;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.FlowLayoutPanel accoutsFlowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private LoginUCView loginucView1;
    }
}

