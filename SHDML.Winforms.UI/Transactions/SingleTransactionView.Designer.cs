
using SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls;
using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;

namespace SHDML.Winforms.UI.Transactions
{
    partial class SingleTransactionView
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
            this.singleTransactionDesktopflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hrBorderLabel1 = new System.Windows.Forms.Label();
            this.billingAccountInfo = new SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls.SelectAccountUserControl();
            this.hrBorderLabel2 = new System.Windows.Forms.Label();
            this.selectCategoryUserControl = new SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls.SelectCategoryUserControl();
            this.selectContrAgentUserControl = new SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions.SelectContrAgentUserControl();
            this.selectFamilyMemberUserControl = new SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions.SelectFamilyMemberUserControl();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addedSingleTransactionButton = new System.Windows.Forms.Button();
            this.cancelSingleTransactionButton = new System.Windows.Forms.Button();
            this.singleTransactionDesktopflowLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // singleTransactionDesktopflowLayoutPanel
            // 
            this.singleTransactionDesktopflowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.singleTransactionDesktopflowLayoutPanel.AutoSize = true;
            this.singleTransactionDesktopflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.hrBorderLabel1);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.billingAccountInfo);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.hrBorderLabel2);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.selectCategoryUserControl);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.selectContrAgentUserControl);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.selectFamilyMemberUserControl);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel);
            this.singleTransactionDesktopflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.singleTransactionDesktopflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.singleTransactionDesktopflowLayoutPanel.Name = "singleTransactionDesktopflowLayoutPanel";
            this.singleTransactionDesktopflowLayoutPanel.Size = new System.Drawing.Size(366, 252);
            this.singleTransactionDesktopflowLayoutPanel.TabIndex = 6;
            // 
            // hrBorderLabel1
            // 
            this.hrBorderLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hrBorderLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hrBorderLabel1.Location = new System.Drawing.Point(3, 0);
            this.hrBorderLabel1.Name = "hrBorderLabel1";
            this.hrBorderLabel1.Size = new System.Drawing.Size(359, 2);
            this.hrBorderLabel1.TabIndex = 5;
            // 
            // billingAccountInfo
            // 
            this.billingAccountInfo.AutoSize = true;
            this.billingAccountInfo.BackColor = System.Drawing.SystemColors.Control;
            this.billingAccountInfo.CreditAccount = "";
            this.billingAccountInfo.Date = new System.DateTime(2022, 8, 10, 0, 0, 0, 0);
            this.billingAccountInfo.DebitAccount = "";
            this.billingAccountInfo.Location = new System.Drawing.Point(3, 5);
            this.billingAccountInfo.MaximumSize = new System.Drawing.Size(355, 115);
            this.billingAccountInfo.Name = "billingAccountInfo";
            this.billingAccountInfo.Size = new System.Drawing.Size(354, 84);
            this.billingAccountInfo.TabIndex = 15;
            this.billingAccountInfo.Time = System.TimeSpan.Parse("18:50:32.3993361");
            // 
            // hrBorderLabel2
            // 
            this.hrBorderLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hrBorderLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hrBorderLabel2.Location = new System.Drawing.Point(3, 92);
            this.hrBorderLabel2.Name = "hrBorderLabel2";
            this.hrBorderLabel2.Size = new System.Drawing.Size(359, 2);
            this.hrBorderLabel2.TabIndex = 10;
            // 
            // selectCategoryUserControl
            // 
            this.selectCategoryUserControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectCategoryUserControl.AutoSize = true;
            this.selectCategoryUserControl.CategoryName = "";
            this.selectCategoryUserControl.Location = new System.Drawing.Point(4, 97);
            this.selectCategoryUserControl.Name = "selectCategoryUserControl";
            this.selectCategoryUserControl.Size = new System.Drawing.Size(357, 28);
            this.selectCategoryUserControl.TabIndex = 11;
            // 
            // selectContrAgentUserControl
            // 
            this.selectContrAgentUserControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectContrAgentUserControl.AutoSize = true;
            this.selectContrAgentUserControl.ContragentName = "";
            this.selectContrAgentUserControl.Location = new System.Drawing.Point(4, 131);
            this.selectContrAgentUserControl.Name = "selectContrAgentUserControl";
            this.selectContrAgentUserControl.Size = new System.Drawing.Size(357, 28);
            this.selectContrAgentUserControl.TabIndex = 12;
            // 
            // selectFamilyMemberUserControl
            // 
            this.selectFamilyMemberUserControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFamilyMemberUserControl.AutoSize = true;
            this.selectFamilyMemberUserControl.FamilyMemberName = "";
            this.selectFamilyMemberUserControl.Location = new System.Drawing.Point(4, 165);
            this.selectFamilyMemberUserControl.Name = "selectFamilyMemberUserControl";
            this.selectFamilyMemberUserControl.Size = new System.Drawing.Size(357, 28);
            this.selectFamilyMemberUserControl.TabIndex = 13;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonsTableLayoutPanel.AutoSize = true;
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.Controls.Add(this.addedSingleTransactionButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.cancelSingleTransactionButton, 2, 0);
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 199);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(360, 38);
            this.buttonsTableLayoutPanel.TabIndex = 14;
            // 
            // addedSingleTransactionButton
            // 
            this.addedSingleTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addedSingleTransactionButton.AutoSize = true;
            this.addedSingleTransactionButton.Location = new System.Drawing.Point(3, 3);
            this.addedSingleTransactionButton.Name = "addedSingleTransactionButton";
            this.addedSingleTransactionButton.Size = new System.Drawing.Size(114, 32);
            this.addedSingleTransactionButton.TabIndex = 0;
            this.addedSingleTransactionButton.Text = "Добавить";
            this.addedSingleTransactionButton.UseVisualStyleBackColor = true;
            this.addedSingleTransactionButton.Click += new System.EventHandler(this.addedSingleTransactionButton_Click);
            // 
            // cancelSingleTransactionButton
            // 
            this.cancelSingleTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelSingleTransactionButton.AutoSize = true;
            this.cancelSingleTransactionButton.Location = new System.Drawing.Point(243, 3);
            this.cancelSingleTransactionButton.Name = "cancelSingleTransactionButton";
            this.cancelSingleTransactionButton.Size = new System.Drawing.Size(114, 32);
            this.cancelSingleTransactionButton.TabIndex = 1;
            this.cancelSingleTransactionButton.Text = "Отмена";
            this.cancelSingleTransactionButton.UseVisualStyleBackColor = true;
            // 
            // SingleTransactionView
            // 
            this.AcceptButton = this.addedSingleTransactionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelSingleTransactionButton;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.singleTransactionDesktopflowLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 400);
            this.Name = "SingleTransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddSingleTransactionForm";
            this.Load += new System.EventHandler(this.AddSingleTransactionForm_Load);
            this.singleTransactionDesktopflowLayoutPanel.ResumeLayout(false);
            this.singleTransactionDesktopflowLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel singleTransactionDesktopflowLayoutPanel;
        private System.Windows.Forms.Label hrBorderLabel1;
        private System.Windows.Forms.Label hrBorderLabel2;
        private SelectCategoryUserControl selectCategoryUserControl;
        private SelectContrAgentUserControl selectContrAgentUserControl;
        private SelectFamilyMemberUserControl selectFamilyMemberUserControl;
        public SelectAccountUserControl billingAccountInfo;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addedSingleTransactionButton;
        private System.Windows.Forms.Button cancelSingleTransactionButton;
    }
}