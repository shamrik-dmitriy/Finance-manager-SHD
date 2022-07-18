
namespace SHDML.Winforms.UI.Transactions.SingleTransaction
{
    partial class AddSingleTransactionForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectTypeTransactionUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SelectTypeTransactionUserControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCategoryUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SelectCategoryUserControl();
            this.selectContrAgentUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SelectContrAgentUserControl();
            this.selectFamilyMemberUserControl1 = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SelectFamilyMemberUserControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.selectTypeTransactionUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.selectCategoryUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.selectContrAgentUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.selectFamilyMemberUserControl1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 267);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // selectTypeTransactionUserControl1
            // 
            this.selectTypeTransactionUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectTypeTransactionUserControl1.AutoSize = true;
            this.selectTypeTransactionUserControl1.Location = new System.Drawing.Point(5, 3);
            this.selectTypeTransactionUserControl1.Name = "selectTypeTransactionUserControl1";
            this.selectTypeTransactionUserControl1.Size = new System.Drawing.Size(355, 26);
            this.selectTypeTransactionUserControl1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Введите название транзакции";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 64);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(359, 39);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Введите описание транзакции";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 2);
            this.label1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(183, 111);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 2);
            this.label2.TabIndex = 10;
            // 
            // selectCategoryUserControl1
            // 
            this.selectCategoryUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectCategoryUserControl1.AutoSize = true;
            this.selectCategoryUserControl1.Location = new System.Drawing.Point(4, 119);
            this.selectCategoryUserControl1.Name = "selectCategoryUserControl1";
            this.selectCategoryUserControl1.Size = new System.Drawing.Size(357, 28);
            this.selectCategoryUserControl1.TabIndex = 11;
            // 
            // selectContrAgentUserControl1
            // 
            this.selectContrAgentUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectContrAgentUserControl1.AutoSize = true;
            this.selectContrAgentUserControl1.Location = new System.Drawing.Point(4, 153);
            this.selectContrAgentUserControl1.Name = "selectContrAgentUserControl1";
            this.selectContrAgentUserControl1.Size = new System.Drawing.Size(357, 28);
            this.selectContrAgentUserControl1.TabIndex = 12;
            // 
            // selectFamilyMemberUserControl1
            // 
            this.selectFamilyMemberUserControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFamilyMemberUserControl1.AutoSize = true;
            this.selectFamilyMemberUserControl1.Location = new System.Drawing.Point(4, 187);
            this.selectFamilyMemberUserControl1.Name = "selectFamilyMemberUserControl1";
            this.selectFamilyMemberUserControl1.Size = new System.Drawing.Size(357, 28);
            this.selectFamilyMemberUserControl1.TabIndex = 13;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 221);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 38);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(243, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddSingleTransactionForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(366, 267);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 306);
            this.Name = "AddSingleTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSingleTransactionForm";
            this.Load += new System.EventHandler(this.AddSingleTransactionForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private SingleTransactionUserControls.SelectAccountUserControl selectAccountUserControl1;
        private SingleTransactionUserControls.SelectTypeTransactionUserControl selectTypeTransactionUserControl;
        private SingleTransactionUserControls.SelectTypeTransactionUserControl selectTypeTransactionUserControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private SingleTransactionUserControls.SelectCategoryUserControl selectCategoryUserControl1;
        private SingleTransactionUserControls.SelectContrAgentUserControl selectContrAgentUserControl1;
        private SingleTransactionUserControls.SelectFamilyMemberUserControl selectFamilyMemberUserControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}