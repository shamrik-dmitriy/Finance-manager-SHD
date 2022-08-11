
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
            this._categoryUcView = new SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls.CategoryUCView();
            this._contrAgentUcView = new SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions.ContrAgentUCView();
            this._familyMemberUcView = new SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions.FamilyMemberUCView();
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
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this._categoryUcView);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this._contrAgentUcView);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this._familyMemberUcView);
            this.singleTransactionDesktopflowLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel);
            this.singleTransactionDesktopflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.singleTransactionDesktopflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.singleTransactionDesktopflowLayoutPanel.Name = "singleTransactionDesktopflowLayoutPanel";
            this.singleTransactionDesktopflowLayoutPanel.Size = new System.Drawing.Size(366, 252);
            this.singleTransactionDesktopflowLayoutPanel.TabIndex = 6;
            // 
            // _categoryUcView
            // 
            this._categoryUcView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._categoryUcView.AutoSize = true;
            this._categoryUcView.CategoryName = "";
            this._categoryUcView.Location = new System.Drawing.Point(4, 3);
            this._categoryUcView.Name = "_categoryUcView";
            this._categoryUcView.Size = new System.Drawing.Size(357, 28);
            this._categoryUcView.TabIndex = 11;
            // 
            // _contrAgentUcView
            // 
            this._contrAgentUcView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._contrAgentUcView.AutoSize = true;
            this._contrAgentUcView.ContragentName = "";
            this._contrAgentUcView.Location = new System.Drawing.Point(4, 37);
            this._contrAgentUcView.Name = "_contrAgentUcView";
            this._contrAgentUcView.Size = new System.Drawing.Size(357, 28);
            this._contrAgentUcView.TabIndex = 12;
            // 
            // _familyMemberUcView
            // 
            this._familyMemberUcView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._familyMemberUcView.AutoSize = true;
            this._familyMemberUcView.FamilyMemberName = "";
            this._familyMemberUcView.Location = new System.Drawing.Point(4, 71);
            this._familyMemberUcView.Name = "_familyMemberUcView";
            this._familyMemberUcView.Size = new System.Drawing.Size(357, 28);
            this._familyMemberUcView.TabIndex = 13;
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
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 105);
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
        private CategoryUCView _categoryUcView;
        private ContrAgentUCView _contrAgentUcView;
        private FamilyMemberUCView _familyMemberUcView;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addedSingleTransactionButton;
        private System.Windows.Forms.Button cancelSingleTransactionButton;
    }
}