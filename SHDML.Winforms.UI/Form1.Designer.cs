
namespace SHDML.Winforms.UI
{
	partial class Form1
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
            this.splitContainerMainDesktop = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlAuth = new SHDML.Winforms.UI.UserControls.UserControlAuth();
            this.buttonSign = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonTransactionReview = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerView = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userControlAccountInfo2 = new SHDML.Winforms.UI.UserControls.Wallet.UserControlTotalSumAccountsInfo();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlCategoryAccount1 = new SHDML.Winforms.UI.UserControls.Wallet.UserControlCategoryAccount();
            this.userControlCategoryAccount2 = new SHDML.Winforms.UI.UserControls.Wallet.UserControlCategoryAccount();
            this.userControlCategoryAccount3 = new SHDML.Winforms.UI.UserControls.Wallet.UserControlCategoryAccount();
            this.userControlCategoryAccount4 = new SHDML.Winforms.UI.UserControls.Wallet.UserControlCategoryAccount();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnVerified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTypeOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainDesktop)).BeginInit();
            this.splitContainerMainDesktop.Panel1.SuspendLayout();
            this.splitContainerMainDesktop.Panel2.SuspendLayout();
            this.splitContainerMainDesktop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerView)).BeginInit();
            this.splitContainerView.Panel1.SuspendLayout();
            this.splitContainerView.Panel2.SuspendLayout();
            this.splitContainerView.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMainDesktop
            // 
            this.splitContainerMainDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMainDesktop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMainDesktop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMainDesktop.Name = "splitContainerMainDesktop";
            this.splitContainerMainDesktop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMainDesktop.Panel1
            // 
            this.splitContainerMainDesktop.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMainDesktop.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainerMainDesktop.Panel2
            // 
            this.splitContainerMainDesktop.Panel2.Controls.Add(this.splitContainerView);
            this.splitContainerMainDesktop.Size = new System.Drawing.Size(1208, 627);
            this.splitContainerMainDesktop.SplitterDistance = 100;
            this.splitContainerMainDesktop.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonSign);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.buttonTransactionReview);
            this.flowLayoutPanel1.Controls.Add(this.buttonCategories);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 76);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.userControlAuth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 70);
            this.panel1.TabIndex = 17;
            // 
            // userControlAuth
            // 
            this.userControlAuth.AutoSize = true;
            this.userControlAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAuth.Location = new System.Drawing.Point(0, 0);
            this.userControlAuth.MaximumSize = new System.Drawing.Size(309, 70);
            this.userControlAuth.MinimumSize = new System.Drawing.Size(309, 70);
            this.userControlAuth.Name = "userControlAuth";
            this.userControlAuth.Size = new System.Drawing.Size(309, 70);
            this.userControlAuth.TabIndex = 1;
            // 
            // buttonSign
            // 
            this.buttonSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSign.Location = new System.Drawing.Point(318, 3);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(75, 70);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "Войти";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(399, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 70);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // buttonTransactionReview
            // 
            this.buttonTransactionReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionReview.Location = new System.Drawing.Point(408, 3);
            this.buttonTransactionReview.Name = "buttonTransactionReview";
            this.buttonTransactionReview.Size = new System.Drawing.Size(84, 70);
            this.buttonTransactionReview.TabIndex = 5;
            this.buttonTransactionReview.Text = "Обзор транзакций";
            this.buttonTransactionReview.UseVisualStyleBackColor = true;
            this.buttonTransactionReview.Click += new System.EventHandler(this.buttonTransactionReview_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategories.Location = new System.Drawing.Point(498, 3);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(75, 70);
            this.buttonCategories.TabIndex = 7;
            this.buttonCategories.Text = "Обзор счетов";
            this.buttonCategories.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(579, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 70);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(588, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Категории";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // splitContainerView
            // 
            this.splitContainerView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerView.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerView.Location = new System.Drawing.Point(0, 0);
            this.splitContainerView.Name = "splitContainerView";
            // 
            // splitContainerView.Panel1
            // 
            this.splitContainerView.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainerView.Panel2
            // 
            this.splitContainerView.Panel2.Controls.Add(this.panel3);
            this.splitContainerView.Size = new System.Drawing.Size(1208, 523);
            this.splitContainerView.SplitterDistance = 315;
            this.splitContainerView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 521);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userControlAccountInfo2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(313, 521);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // userControlAccountInfo2
            // 
            this.userControlAccountInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAccountInfo2.Location = new System.Drawing.Point(0, 0);
            this.userControlAccountInfo2.Name = "userControlAccountInfo2";
            this.userControlAccountInfo2.Size = new System.Drawing.Size(313, 40);
            this.userControlAccountInfo2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.userControlCategoryAccount1);
            this.flowLayoutPanel2.Controls.Add(this.userControlCategoryAccount2);
            this.flowLayoutPanel2.Controls.Add(this.userControlCategoryAccount3);
            this.flowLayoutPanel2.Controls.Add(this.userControlCategoryAccount4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(313, 480);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // userControlCategoryAccount1
            // 
            this.userControlCategoryAccount1.AutoScroll = true;
            this.userControlCategoryAccount1.AutoSize = true;
            this.userControlCategoryAccount1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControlCategoryAccount1.Location = new System.Drawing.Point(3, 3);
            this.userControlCategoryAccount1.MaximumSize = new System.Drawing.Size(310, 250);
            this.userControlCategoryAccount1.MinimumSize = new System.Drawing.Size(310, 10);
            this.userControlCategoryAccount1.Name = "userControlCategoryAccount1";
            this.userControlCategoryAccount1.Size = new System.Drawing.Size(310, 46);
            this.userControlCategoryAccount1.TabIndex = 0;
            // 
            // userControlCategoryAccount2
            // 
            this.userControlCategoryAccount2.AutoScroll = true;
            this.userControlCategoryAccount2.AutoSize = true;
            this.userControlCategoryAccount2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControlCategoryAccount2.Location = new System.Drawing.Point(3, 55);
            this.userControlCategoryAccount2.MaximumSize = new System.Drawing.Size(310, 250);
            this.userControlCategoryAccount2.MinimumSize = new System.Drawing.Size(310, 10);
            this.userControlCategoryAccount2.Name = "userControlCategoryAccount2";
            this.userControlCategoryAccount2.Size = new System.Drawing.Size(310, 46);
            this.userControlCategoryAccount2.TabIndex = 1;
            // 
            // userControlCategoryAccount3
            // 
            this.userControlCategoryAccount3.AutoScroll = true;
            this.userControlCategoryAccount3.AutoSize = true;
            this.userControlCategoryAccount3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControlCategoryAccount3.Location = new System.Drawing.Point(3, 107);
            this.userControlCategoryAccount3.MaximumSize = new System.Drawing.Size(310, 250);
            this.userControlCategoryAccount3.MinimumSize = new System.Drawing.Size(310, 10);
            this.userControlCategoryAccount3.Name = "userControlCategoryAccount3";
            this.userControlCategoryAccount3.Size = new System.Drawing.Size(310, 46);
            this.userControlCategoryAccount3.TabIndex = 2;
            // 
            // userControlCategoryAccount4
            // 
            this.userControlCategoryAccount4.AutoScroll = true;
            this.userControlCategoryAccount4.AutoSize = true;
            this.userControlCategoryAccount4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userControlCategoryAccount4.Location = new System.Drawing.Point(3, 159);
            this.userControlCategoryAccount4.MaximumSize = new System.Drawing.Size(310, 250);
            this.userControlCategoryAccount4.MinimumSize = new System.Drawing.Size(310, 10);
            this.userControlCategoryAccount4.Name = "userControlCategoryAccount4";
            this.userControlCategoryAccount4.Size = new System.Drawing.Size(310, 46);
            this.userControlCategoryAccount4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 521);
            this.panel3.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitContainer2.Panel1MinSize = 27;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(887, 521);
            this.splitContainer2.SplitterDistance = 30;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonAddReceipt);
            this.flowLayoutPanel3.Controls.Add(this.buttonAddTransaction);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(887, 30);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.Location = new System.Drawing.Point(3, 3);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(116, 23);
            this.buttonAddReceipt.TabIndex = 3;
            this.buttonAddReceipt.Text = "Добавить чек";
            this.buttonAddReceipt.UseVisualStyleBackColor = true;
            this.buttonAddReceipt.Click += new System.EventHandler(this.buttonAddReceipt_Click);
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(125, 3);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(132, 23);
            this.buttonAddTransaction.TabIndex = 1;
            this.buttonAddTransaction.Text = "Добавить операцию";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVerified,
            this.ColumnTypeOperation,
            this.ColumnAccount,
            this.ColumnDateOperation,
            this.ColumnSumm,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnVerified
            // 
            this.ColumnVerified.HeaderText = "Проверено";
            this.ColumnVerified.Name = "ColumnVerified";
            // 
            // ColumnTypeOperation
            // 
            this.ColumnTypeOperation.HeaderText = "Тип операции";
            this.ColumnTypeOperation.Name = "ColumnTypeOperation";
            // 
            // ColumnAccount
            // 
            this.ColumnAccount.HeaderText = "Счёт";
            this.ColumnAccount.Name = "ColumnAccount";
            // 
            // ColumnDateOperation
            // 
            this.ColumnDateOperation.HeaderText = "Дата";
            this.ColumnDateOperation.Name = "ColumnDateOperation";
            // 
            // ColumnSumm
            // 
            this.ColumnSumm.HeaderText = "Сумма";
            this.ColumnSumm.Name = "ColumnSumm";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Изменить";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEdit.Text = "Изменить";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Удалить";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Удалить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 627);
            this.Controls.Add(this.splitContainerMainDesktop);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainerMainDesktop.Panel1.ResumeLayout(false);
            this.splitContainerMainDesktop.Panel1.PerformLayout();
            this.splitContainerMainDesktop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMainDesktop)).EndInit();
            this.splitContainerMainDesktop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerView.Panel1.ResumeLayout(false);
            this.splitContainerView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerView)).EndInit();
            this.splitContainerView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainerMainDesktop;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.Button buttonSign;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Button buttonTransactionReview;
		private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private UserControls.Wallet.UserControlTotalSumAccountsInfo userControlAccountInfo1;
        private UserControls.UserControlAuth userControlAuth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UserControls.Wallet.UserControlTotalSumAccountsInfo userControlAccountInfo2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumm;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.Button buttonAddTransaction;
        private UserControls.Wallet.UserControlCategoryAccount userControlCategoryAccount1;
        private UserControls.Wallet.UserControlCategoryAccount userControlCategoryAccount2;
        private UserControls.Wallet.UserControlCategoryAccount userControlCategoryAccount3;
        private UserControls.Wallet.UserControlCategoryAccount userControlCategoryAccount4;
    }
}

