namespace SHDML.Winforms.UI.Transactions.MultipleTransaction
{
    partial class MultipleTransactionForm
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
            this.selectFamilyMemberUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SelectFamilyMemberUserControl();
            this.accountInfoUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl();
            this.dateTransactionUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.DateTransactionUserControl();
            this.addedTransactionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.multipleTransactionFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multipleTransactionFlowLayoutPanel
            // 
            this.multipleTransactionFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.multipleTransactionFlowLayoutPanel.AutoSize = true;
            this.multipleTransactionFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multipleTransactionFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.nameOfRetailertextBox);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.selectFamilyMemberUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.accountInfoUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.dateTransactionUserControl1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.addedTransactionButton);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.label1);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.ItemsFlowLayoutPanel);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.label2);
            this.multipleTransactionFlowLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.multipleTransactionFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.multipleTransactionFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.multipleTransactionFlowLayoutPanel.Name = "multipleTransactionFlowLayoutPanel";
            this.multipleTransactionFlowLayoutPanel.Size = new System.Drawing.Size(365, 216);
            this.multipleTransactionFlowLayoutPanel.TabIndex = 7;
            this.multipleTransactionFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // nameOfRetailertextBox
            // 
            this.nameOfRetailertextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameOfRetailertextBox.Location = new System.Drawing.Point(3, 3);
            this.nameOfRetailertextBox.Name = "nameOfRetailertextBox";
            this.nameOfRetailertextBox.PlaceholderText = "Название торвой точки";
            this.nameOfRetailertextBox.Size = new System.Drawing.Size(359, 23);
            this.nameOfRetailertextBox.TabIndex = 2;
            // 
            // selectFamilyMemberUserControl1
            // 
            this.selectFamilyMemberUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFamilyMemberUserControl1.AutoSize = true;
            this.selectFamilyMemberUserControl1.Location = new System.Drawing.Point(4, 32);
            this.selectFamilyMemberUserControl1.Name = "selectFamilyMemberUserControl1";
            this.selectFamilyMemberUserControl1.Size = new System.Drawing.Size(357, 28);
            this.selectFamilyMemberUserControl1.TabIndex = 13;
            // 
            // accountInfoUserControl1
            // 
            this.accountInfoUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountInfoUserControl1.AutoSize = true;
            this.accountInfoUserControl1.LabelOfTypeOperation = "Зачислить на счёт";
            this.accountInfoUserControl1.Location = new System.Drawing.Point(4, 66);
            this.accountInfoUserControl1.Name = "accountInfoUserControl1";
            this.accountInfoUserControl1.Size = new System.Drawing.Size(357, 28);
            this.accountInfoUserControl1.TabIndex = 15;
            this.accountInfoUserControl1.Load += new System.EventHandler(this.accountInfoUserControl1_Load);
            // 
            // dateTransactionUserControl1
            // 
            this.dateTransactionUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTransactionUserControl1.AutoSize = true;
            this.dateTransactionUserControl1.Location = new System.Drawing.Point(4, 100);
            this.dateTransactionUserControl1.Name = "dateTransactionUserControl1";
            this.dateTransactionUserControl1.Size = new System.Drawing.Size(357, 28);
            this.dateTransactionUserControl1.TabIndex = 19;
            // 
            // addedTransactionButton
            // 
            this.addedTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addedTransactionButton.AutoSize = true;
            this.addedTransactionButton.Location = new System.Drawing.Point(4, 134);
            this.addedTransactionButton.Name = "addedTransactionButton";
            this.addedTransactionButton.Size = new System.Drawing.Size(357, 32);
            this.addedTransactionButton.TabIndex = 16;
            this.addedTransactionButton.Text = "Добавить транзакцию";
            this.addedTransactionButton.UseVisualStyleBackColor = true;
            this.addedTransactionButton.Click += new System.EventHandler(this.addedTransactionButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 169);
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
            this.ItemsFlowLayoutPanel.Location = new System.Drawing.Point(182, 174);
            this.ItemsFlowLayoutPanel.Name = "ItemsFlowLayoutPanel";
            this.ItemsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.ItemsFlowLayoutPanel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 2);
            this.label2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 31);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(167, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MultipleTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(367, 223);
            this.Controls.Add(this.multipleTransactionFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 262);
            this.Name = "MultipleTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MultipleTransactionForm";
            this.multipleTransactionFlowLayoutPanel.ResumeLayout(false);
            this.multipleTransactionFlowLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel multipleTransactionFlowLayoutPanel;
        private System.Windows.Forms.TextBox nameOfRetailertextBox;
        private SingleTransaction.SingleTransactionUserControls.SelectFamilyMemberUserControl selectFamilyMemberUserControl1;
        private SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl accountInfoUserControl1;
        private System.Windows.Forms.Button addedTransactionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel ItemsFlowLayoutPanel;
        private SingleTransaction.SingleTransactionUserControls.DateTransactionUserControl dateTransactionUserControl1;
    }
}