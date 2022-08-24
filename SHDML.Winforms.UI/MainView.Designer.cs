
using SHDML.Winforms.UI.UserControls.Authorization;

namespace SHDML.Winforms.UI
{
	partial class MainView
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
            this._authUcView = new SHDML.Winforms.UI.UserControls.Authorization.AuthUCView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.buttonTransactionReview = new System.Windows.Forms.Button();
            this.seeAccountButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.seeCategoriesButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerView = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.accountActionAndTotalSumsplitContainer = new System.Windows.Forms.SplitContainer();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accoutsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ваToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.accountActionAndTotalSumsplitContainer)).BeginInit();
            this.accountActionAndTotalSumsplitContainer.Panel1.SuspendLayout();
            this.accountActionAndTotalSumsplitContainer.SuspendLayout();
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
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.buttonTransactionReview);
            this.flowLayoutPanel1.Controls.Add(this.seeAccountButton);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.seeCategoriesButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1208, 76);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this._authUcView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 70);
            this.panel1.TabIndex = 17;
            // 
            // _authUcView
            // 
            this._authUcView.AutoSize = true;
            this._authUcView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._authUcView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._authUcView.Location = new System.Drawing.Point(0, 0);
            this._authUcView.MaximumSize = new System.Drawing.Size(309, 70);
            this._authUcView.MinimumSize = new System.Drawing.Size(309, 70);
            this._authUcView.Name = "_authUcView";
            this._authUcView.Size = new System.Drawing.Size(309, 70);
            this._authUcView.TabIndex = 1;
            this._authUcView.Visible = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(318, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 70);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // buttonTransactionReview
            // 
            this.buttonTransactionReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionReview.Location = new System.Drawing.Point(327, 3);
            this.buttonTransactionReview.Name = "buttonTransactionReview";
            this.buttonTransactionReview.Size = new System.Drawing.Size(84, 70);
            this.buttonTransactionReview.TabIndex = 5;
            this.buttonTransactionReview.Text = "Обзор транзакций";
            this.buttonTransactionReview.UseVisualStyleBackColor = true;
            this.buttonTransactionReview.Click += new System.EventHandler(this.buttonTransactionReview_Click);
            // 
            // seeAccountButton
            // 
            this.seeAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeAccountButton.Location = new System.Drawing.Point(417, 3);
            this.seeAccountButton.Name = "seeAccountButton";
            this.seeAccountButton.Size = new System.Drawing.Size(75, 70);
            this.seeAccountButton.TabIndex = 7;
            this.seeAccountButton.Text = "Обзор счетов";
            this.seeAccountButton.UseVisualStyleBackColor = true;
            this.seeAccountButton.Visible = false;
            this.seeAccountButton.Click += new System.EventHandler(this.seeAccountButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(498, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 70);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // seeCategoriesButton
            // 
            this.seeCategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeCategoriesButton.Location = new System.Drawing.Point(507, 3);
            this.seeCategoriesButton.Name = "seeCategoriesButton";
            this.seeCategoriesButton.Size = new System.Drawing.Size(75, 70);
            this.seeCategoriesButton.TabIndex = 21;
            this.seeCategoriesButton.Text = "Категории";
            this.seeCategoriesButton.UseVisualStyleBackColor = true;
            this.seeCategoriesButton.Visible = false;
            this.seeCategoriesButton.Click += new System.EventHandler(this.seeCategoriesButton_Click);
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.ваToolStripMenuItem,
            this.выйтиToolStripMenuItem});
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
            this.splitContainer1.Panel1.Controls.Add(this.accountActionAndTotalSumsplitContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.accoutsFlowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(313, 521);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
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
            this.accountActionAndTotalSumsplitContainer.Size = new System.Drawing.Size(313, 91);
            this.accountActionAndTotalSumsplitContainer.SplitterDistance = 31;
            this.accountActionAndTotalSumsplitContainer.TabIndex = 0;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addAccountButton.Location = new System.Drawing.Point(0, 0);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(313, 31);
            this.addAccountButton.TabIndex = 0;
            this.addAccountButton.Text = "Добавить счёт";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // accoutsFlowLayoutPanel
            // 
            this.accoutsFlowLayoutPanel.AutoSize = true;
            this.accoutsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.accoutsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accoutsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.accoutsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.accoutsFlowLayoutPanel.Name = "accoutsFlowLayoutPanel";
            this.accoutsFlowLayoutPanel.Size = new System.Drawing.Size(313, 429);
            this.accoutsFlowLayoutPanel.TabIndex = 0;
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
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Создать";
            this.открытьToolStripMenuItem.Visible = false;
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Visible = false;
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // настройкиToolStripMenuItem
            // 
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
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
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
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Visible = false;
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
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
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
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 627);
            this.Controls.Add(this.splitContainerMainDesktop);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
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
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.accountActionAndTotalSumsplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountActionAndTotalSumsplitContainer)).EndInit();
            this.accountActionAndTotalSumsplitContainer.ResumeLayout(false);
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
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Button buttonTransactionReview;
		private System.Windows.Forms.Button seeAccountButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button seeCategoriesButton;
        private UserControls.Wallet.TotalSumInAccountsUCView _inAccountInfo1;
        private AuthUCView _authUcView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.SplitContainer accountActionAndTotalSumsplitContainer;
        private System.Windows.Forms.Button addAccountButton;
        private UserControls.Wallet.TotalSumInAccountsUCView _totalSumInAccountsInfoucView1;
        private System.Windows.Forms.FlowLayoutPanel accoutsFlowLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumm;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}

