
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.debitAccountInfoUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl();
            this.sumTransactionUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.SumTransactionUserControl();
            this.creditAccountInfoUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.AccountInfoUserControl();
            this.dateTransactionUserControl = new SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls.DateTransactionUserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.debitAccountInfoUserControl);
            this.flowLayoutPanel1.Controls.Add(this.sumTransactionUserControl);
            this.flowLayoutPanel1.Controls.Add(this.creditAccountInfoUserControl);
            this.flowLayoutPanel1.Controls.Add(this.dateTransactionUserControl);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(363, 136);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(363, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 136);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // debitAccountInfoUserControl
            // 
            this.debitAccountInfoUserControl.AutoSize = true;
            this.debitAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
            this.debitAccountInfoUserControl.Location = new System.Drawing.Point(3, 3);
            this.debitAccountInfoUserControl.Name = "debitAccountInfoUserControl";
            this.debitAccountInfoUserControl.Size = new System.Drawing.Size(357, 28);
            this.debitAccountInfoUserControl.TabIndex = 0;
            // 
            // sumTransactionUserControl
            // 
            this.sumTransactionUserControl.AutoSize = true;
            this.sumTransactionUserControl.Location = new System.Drawing.Point(3, 37);
            this.sumTransactionUserControl.Name = "sumTransactionUserControl";
            this.sumTransactionUserControl.Size = new System.Drawing.Size(357, 28);
            this.sumTransactionUserControl.TabIndex = 1;
            // 
            // creditAccountInfoUserControl
            // 
            this.creditAccountInfoUserControl.AutoSize = true;
            this.creditAccountInfoUserControl.LabelOfTypeOperation = "Зачислить на счёт";
            this.creditAccountInfoUserControl.Location = new System.Drawing.Point(3, 71);
            this.creditAccountInfoUserControl.Name = "creditAccountInfoUserControl";
            this.creditAccountInfoUserControl.Size = new System.Drawing.Size(357, 28);
            this.creditAccountInfoUserControl.TabIndex = 2;
            // 
            // dateTransactionUserControl
            // 
            this.dateTransactionUserControl.AutoSize = true;
            this.dateTransactionUserControl.Location = new System.Drawing.Point(3, 105);
            this.dateTransactionUserControl.Name = "dateTransactionUserControl";
            this.dateTransactionUserControl.Size = new System.Drawing.Size(357, 28);
            this.dateTransactionUserControl.TabIndex = 3;
            // 
            // SelectAccountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SelectAccountUserControl";
            this.Size = new System.Drawing.Size(365, 139);
            this.Load += new System.EventHandler(this.SelectAccountUserControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AccountInfoUserControl debitAccountInfoUserControl;
        private SumTransactionUserControl sumTransactionUserControl;
        private DateTransactionUserControl dateTransactionUserControl;
        private AccountInfoUserControl creditAccountInfoUserControl;
    }
}
