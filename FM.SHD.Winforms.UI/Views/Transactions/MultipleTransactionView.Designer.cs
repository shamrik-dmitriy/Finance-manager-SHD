using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;

namespace SHDML.Winforms.UI.Views.Transactions
{
    partial class MultipleTransactionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multipleTransactionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameOfRetailertextBox = new System.Windows.Forms.TextBox();
            this._contrAgentUserControl1 = new ContrAgentUCView();
            this._identityUserControl1 = new IdentityUCView();
            this._accountInfoUserControl1 = new AccountInfoUCView();
            this.dateTransactionUserControl1 = new DateTransactionUCView();
            this.addedTransactionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addReceiptButton = new System.Windows.Forms.Button();
            this.cancelReceipButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._totalSumTransactionUcView = new SumTransactionUCView();
            this.multipleTransactionFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // multipleTransactionFlowLayoutPanel
            // 
            this.multipleTransactionFlowLayoutPanel.AutoSize = true;
            this.multipleTransactionFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multipleTransactionFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.nameOfRetailertextBox);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this._contrAgentUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this._identityUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this._accountInfoUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.dateTransactionUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.addedTransactionButton);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.label1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.ItemsFlowLayoutPanel);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.label2);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this._totalSumTransactionUcView);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.multipleTransactionFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.multipleTransactionFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.multipleTransactionFlowLayoutPanel.Name = "multipleTransactionFlowLayoutPanel";
            this.multipleTransactionFlowLayoutPanel.Size = new System.Drawing.Size(366, 284);
            this.multipleTransactionFlowLayoutPanel.TabIndex = 7;
            // 
            // nameOfRetailertextBox
            // 
            this.nameOfRetailertextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameOfRetailertextBox.Location = new System.Drawing.Point(3, 3);
            this.nameOfRetailertextBox.Name = "nameOfRetailertextBox";
            this.nameOfRetailertextBox.PlaceholderText = "Название торвой точки";
            this.nameOfRetailertextBox.Size = new System.Drawing.Size(359, 23);
            this.nameOfRetailertextBox.TabIndex = 2;
            this.nameOfRetailertextBox.TextChanged += new System.EventHandler(this.nameOfRetailertextBox_TextChanged);
            // 
            // _contrAgentUserControl1
            // 
            this._contrAgentUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._contrAgentUserControl1.AutoSize = true;
            this._contrAgentUserControl1.Location = new System.Drawing.Point(4, 32);
            this._contrAgentUserControl1.Name = "_contrAgentUserControl1";
            this._contrAgentUserControl1.Size = new System.Drawing.Size(357, 28);
            this._contrAgentUserControl1.TabIndex = 20;
            // 
            // _identityUserControl1
            // 
            this._identityUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._identityUserControl1.AutoSize = true;
            this._identityUserControl1.Location = new System.Drawing.Point(4, 66);
            this._identityUserControl1.Name = "_identityUserControl1";
            this._identityUserControl1.Size = new System.Drawing.Size(357, 28);
            this._identityUserControl1.TabIndex = 13;
            // 
            // _accountInfoUserControl1
            // 
            this._accountInfoUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._accountInfoUserControl1.AutoSize = true;
            this._accountInfoUserControl1.LabelOfTypeOperation = "Зачислить на счёт";
            this._accountInfoUserControl1.Location = new System.Drawing.Point(4, 100);
            this._accountInfoUserControl1.Name = "_accountInfoUserControl1";
            this._accountInfoUserControl1.Size = new System.Drawing.Size(357, 28);
            this._accountInfoUserControl1.TabIndex = 15;
            this._accountInfoUserControl1.Load += new System.EventHandler(this.accountInfoUserControl1_Load);
            // 
            // dateTransactionUserControl1
            // 
            this.dateTransactionUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTransactionUserControl1.AutoSize = true;
            this.dateTransactionUserControl1.Location = new System.Drawing.Point(4, 134);
            this.dateTransactionUserControl1.Name = "dateTransactionUserControl1";
            this.dateTransactionUserControl1.Size = new System.Drawing.Size(357, 28);
            this.dateTransactionUserControl1.TabIndex = 19;
            // 
            // addedTransactionButton
            // 
            this.addedTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addedTransactionButton.AutoSize = true;
            this.addedTransactionButton.Location = new System.Drawing.Point(4, 168);
            this.addedTransactionButton.Name = "addedTransactionButton";
            this.addedTransactionButton.Size = new System.Drawing.Size(357, 32);
            this.addedTransactionButton.TabIndex = 1;
            this.addedTransactionButton.Text = "Добавить транзакцию";
            this.addedTransactionButton.UseVisualStyleBackColor = true;
            this.addedTransactionButton.Click += new System.EventHandler(this.addedTransactionButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 2);
            this.label1.TabIndex = 5;
            // 
            // ItemsFlowLayoutPanel
            // 
            this.ItemsFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemsFlowLayoutPanel.AutoSize = true;
            this.ItemsFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ItemsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ItemsFlowLayoutPanel.Location = new System.Drawing.Point(183, 208);
            this.ItemsFlowLayoutPanel.Name = "ItemsFlowLayoutPanel";
            this.ItemsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.ItemsFlowLayoutPanel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 2);
            this.label2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.addReceiptButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelReceipButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 31);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // addReceiptButton
            // 
            this.addReceiptButton.AutoSize = true;
            this.addReceiptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addReceiptButton.Location = new System.Drawing.Point(3, 3);
            this.addReceiptButton.Name = "addReceiptButton";
            this.addReceiptButton.Size = new System.Drawing.Size(114, 25);
            this.addReceiptButton.TabIndex = 0;
            this.addReceiptButton.Text = "Сохранить";
            this.addReceiptButton.UseVisualStyleBackColor = true;
            // 
            // cancelReceipButton
            // 
            this.cancelReceipButton.AutoSize = true;
            this.cancelReceipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelReceipButton.Location = new System.Drawing.Point(243, 3);
            this.cancelReceipButton.Name = "cancelReceipButton";
            this.cancelReceipButton.Size = new System.Drawing.Size(114, 25);
            this.cancelReceipButton.TabIndex = 1;
            this.cancelReceipButton.Text = "Отмена";
            this.cancelReceipButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(135, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 94);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // _totalSumTransactionUcView
            // 
            this._totalSumTransactionUcView.AutoSize = true;
            this._totalSumTransactionUcView.Location = new System.Drawing.Point(3, 216);
            this._totalSumTransactionUcView.Name = "_totalSumTransactionUcView";
            this._totalSumTransactionUcView.Size = new System.Drawing.Size(357, 28);
            this._totalSumTransactionUcView.TabIndex = 21;
            // 
            // MultipleTransactionView
            // 
            this.AcceptButton = this.addReceiptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancelReceipButton;
            this.ClientSize = new System.Drawing.Size(367, 282);
            this.Controls.Add(this.multipleTransactionFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 262);
            this.Name = "MultipleTransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MultipleTransactionView";
            this.multipleTransactionFlowLayoutPanel.ResumeLayout(false);
            this.multipleTransactionFlowLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel multipleTransactionFlowLayoutPanel;
        private System.Windows.Forms.TextBox nameOfRetailertextBox;
        private IdentityUCView _identityUserControl1;
        private AccountInfoUCView _accountInfoUserControl1;
        private System.Windows.Forms.Button addedTransactionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addReceiptButton;
        private System.Windows.Forms.Button cancelReceipButton;
        private System.Windows.Forms.FlowLayoutPanel ItemsFlowLayoutPanel;
        private DateTransactionUCView dateTransactionUserControl1;
        private ContrAgentUCView _contrAgentUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SumTransactionUCView _totalSumTransactionUcView;
    }
}