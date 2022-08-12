
using SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions;

namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    partial class AccountsInfoTransactionUCView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.financeInfoOfOperationflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._debitAccountInfoUcView = new AccountInfoUCView();
            this._sumTransactionUcView = new SumTransactionUCView();
            this._creditAccountInfoUcView = new AccountInfoUCView();
            this._dateTransactionUcView = new DateTransactionUCView();
            this.financeInfoOfOperationflowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // financeInfoOfOperationflowLayoutPanel
            // 
            this.financeInfoOfOperationflowLayoutPanel.AutoSize = true;
            this.financeInfoOfOperationflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this._debitAccountInfoUcView);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this._sumTransactionUcView);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this._creditAccountInfoUcView);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this._dateTransactionUcView);
            this.financeInfoOfOperationflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeInfoOfOperationflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.financeInfoOfOperationflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.financeInfoOfOperationflowLayoutPanel.Name = "financeInfoOfOperationflowLayoutPanel";
            this.financeInfoOfOperationflowLayoutPanel.Size = new System.Drawing.Size(355, 115);
            this.financeInfoOfOperationflowLayoutPanel.TabIndex = 8;
            // 
            // _debitAccountInfoUcView
            // 
            this._debitAccountInfoUcView.AutoSize = true;
            this._debitAccountInfoUcView.LabelOfTypeOperation = "Зачислить на счёт";
            this._debitAccountInfoUcView.Location = new System.Drawing.Point(0, 0);
            this._debitAccountInfoUcView.Margin = new System.Windows.Forms.Padding(0);
            this._debitAccountInfoUcView.MaximumSize = new System.Drawing.Size(354, 28);
            this._debitAccountInfoUcView.MinimumSize = new System.Drawing.Size(354, 28);
            this._debitAccountInfoUcView.Name = "_debitAccountInfoUcView";
            this._debitAccountInfoUcView.Size = new System.Drawing.Size(354, 28);
            this._debitAccountInfoUcView.TabIndex = 0;
            // 
            // _sumTransactionUcView
            // 
            this._sumTransactionUcView.AutoSize = true;
            this._sumTransactionUcView.Location = new System.Drawing.Point(0, 28);
            this._sumTransactionUcView.Margin = new System.Windows.Forms.Padding(0);
            this._sumTransactionUcView.MaximumSize = new System.Drawing.Size(354, 28);
            this._sumTransactionUcView.MinimumSize = new System.Drawing.Size(354, 28);
            this._sumTransactionUcView.Name = "_sumTransactionUcView";
            this._sumTransactionUcView.Size = new System.Drawing.Size(354, 28);
            this._sumTransactionUcView.TabIndex = 1;
            // 
            // _creditAccountInfoUcView
            // 
            this._creditAccountInfoUcView.AutoSize = true;
            this._creditAccountInfoUcView.LabelOfTypeOperation = "Зачислить на счёт";
            this._creditAccountInfoUcView.Location = new System.Drawing.Point(0, 56);
            this._creditAccountInfoUcView.Margin = new System.Windows.Forms.Padding(0);
            this._creditAccountInfoUcView.MaximumSize = new System.Drawing.Size(354, 28);
            this._creditAccountInfoUcView.MinimumSize = new System.Drawing.Size(354, 28);
            this._creditAccountInfoUcView.Name = "_creditAccountInfoUcView";
            this._creditAccountInfoUcView.Size = new System.Drawing.Size(354, 28);
            this._creditAccountInfoUcView.TabIndex = 2;
            // 
            // _dateTransactionUcView
            // 
            this._dateTransactionUcView.AutoSize = true;
            this._dateTransactionUcView.Location = new System.Drawing.Point(0, 84);
            this._dateTransactionUcView.Margin = new System.Windows.Forms.Padding(0);
            this._dateTransactionUcView.MaximumSize = new System.Drawing.Size(354, 28);
            this._dateTransactionUcView.MinimumSize = new System.Drawing.Size(354, 28);
            this._dateTransactionUcView.Name = "_dateTransactionUcView";
            this._dateTransactionUcView.Size = new System.Drawing.Size(354, 28);
            this._dateTransactionUcView.TabIndex = 3;
            // 
            // AccountsInfoTransactionUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.financeInfoOfOperationflowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(355, 115);
            this.Name = "AccountsInfoTransactionUCView";
            this.Size = new System.Drawing.Size(355, 115);
            this.financeInfoOfOperationflowLayoutPanel.ResumeLayout(false);
            this.financeInfoOfOperationflowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel financeInfoOfOperationflowLayoutPanel;
        private AccountInfoUCView _debitAccountInfoUcView;
        private SumTransactionUCView _sumTransactionUcView;
        private DateTransactionUCView _dateTransactionUcView;
        private AccountInfoUCView _creditAccountInfoUcView;
    }
}
