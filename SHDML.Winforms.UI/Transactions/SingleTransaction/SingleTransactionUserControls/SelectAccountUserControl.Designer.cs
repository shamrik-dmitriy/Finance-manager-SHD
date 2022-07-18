
namespace SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls
{
    partial class SelectAccountUserControl
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
            this.debitAccountInfoUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl();
            this.sumTransactionUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SumTransactionUserControl();
            this.creditAccountInfoUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl();
            this.dateTransactionUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.DateTransactionUserControl();
            this.financeInfoOfOperationflowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // financeInfoOfOperationflowLayoutPanel
            // 
            this.financeInfoOfOperationflowLayoutPanel.AutoSize = true;
            this.financeInfoOfOperationflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this.debitAccountInfoUserControl);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this.sumTransactionUserControl);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this.creditAccountInfoUserControl);
            this.financeInfoOfOperationflowLayoutPanel.Controls.Add(this.dateTransactionUserControl);
            this.financeInfoOfOperationflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeInfoOfOperationflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.financeInfoOfOperationflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.financeInfoOfOperationflowLayoutPanel.Name = "financeInfoOfOperationflowLayoutPanel";
            this.financeInfoOfOperationflowLayoutPanel.Size = new System.Drawing.Size(355, 115);
            this.financeInfoOfOperationflowLayoutPanel.TabIndex = 8;
            // 
            // debitAccountInfoUserControl
            // 
            this.debitAccountInfoUserControl.AutoSize = true;
            this.debitAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
            this.debitAccountInfoUserControl.Location = new System.Drawing.Point(0, 0);
            this.debitAccountInfoUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.debitAccountInfoUserControl.MaximumSize = new System.Drawing.Size(354, 28);
            this.debitAccountInfoUserControl.MinimumSize = new System.Drawing.Size(354, 28);
            this.debitAccountInfoUserControl.Name = "debitAccountInfoUserControl";
            this.debitAccountInfoUserControl.Size = new System.Drawing.Size(354, 28);
            this.debitAccountInfoUserControl.TabIndex = 0;
            // 
            // sumTransactionUserControl
            // 
            this.sumTransactionUserControl.AutoSize = true;
            this.sumTransactionUserControl.Location = new System.Drawing.Point(0, 28);
            this.sumTransactionUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.sumTransactionUserControl.MaximumSize = new System.Drawing.Size(354, 28);
            this.sumTransactionUserControl.MinimumSize = new System.Drawing.Size(354, 28);
            this.sumTransactionUserControl.Name = "sumTransactionUserControl";
            this.sumTransactionUserControl.Size = new System.Drawing.Size(354, 28);
            this.sumTransactionUserControl.TabIndex = 1;
            // 
            // creditAccountInfoUserControl
            // 
            this.creditAccountInfoUserControl.AutoSize = true;
            this.creditAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
            this.creditAccountInfoUserControl.Location = new System.Drawing.Point(0, 56);
            this.creditAccountInfoUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.creditAccountInfoUserControl.MaximumSize = new System.Drawing.Size(354, 28);
            this.creditAccountInfoUserControl.MinimumSize = new System.Drawing.Size(354, 28);
            this.creditAccountInfoUserControl.Name = "creditAccountInfoUserControl";
            this.creditAccountInfoUserControl.Size = new System.Drawing.Size(354, 28);
            this.creditAccountInfoUserControl.TabIndex = 2;
            // 
            // dateTransactionUserControl
            // 
            this.dateTransactionUserControl.AutoSize = true;
            this.dateTransactionUserControl.Location = new System.Drawing.Point(0, 84);
            this.dateTransactionUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.dateTransactionUserControl.MaximumSize = new System.Drawing.Size(354, 28);
            this.dateTransactionUserControl.MinimumSize = new System.Drawing.Size(354, 28);
            this.dateTransactionUserControl.Name = "dateTransactionUserControl";
            this.dateTransactionUserControl.Size = new System.Drawing.Size(354, 28);
            this.dateTransactionUserControl.TabIndex = 3;
            // 
            // SelectAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.financeInfoOfOperationflowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(355, 115);
            this.Name = "SelectAccountUserControl";
            this.Size = new System.Drawing.Size(355, 115);
            this.Load += new System.EventHandler(this.SelectAccountUserControl_Load);
            this.financeInfoOfOperationflowLayoutPanel.ResumeLayout(false);
            this.financeInfoOfOperationflowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel financeInfoOfOperationflowLayoutPanel;
        private AccountInfoUserControl debitAccountInfoUserControl;
        private SumTransactionUserControl sumTransactionUserControl;
        private DateTransactionUserControl dateTransactionUserControl;
        private AccountInfoUserControl creditAccountInfoUserControl;
    }
}
