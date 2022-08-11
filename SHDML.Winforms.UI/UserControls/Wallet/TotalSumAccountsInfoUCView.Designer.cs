
namespace SHDML.Winforms.UI.UserControls.Wallet
{
    partial class TotalSumAccountsInfoUCView
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalAccountsSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма на счетах:";
            // 
            // labelTotalAccountsSum
            // 
            this.labelTotalAccountsSum.AutoSize = true;
            this.labelTotalAccountsSum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalAccountsSum.Location = new System.Drawing.Point(3, 15);
            this.labelTotalAccountsSum.Name = "labelTotalAccountsSum";
            this.labelTotalAccountsSum.Size = new System.Drawing.Size(262, 25);
            this.labelTotalAccountsSum.TabIndex = 1;
            this.labelTotalAccountsSum.Text = "1200000000000000000 Rub";
            // 
            // UserControlAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTotalAccountsSum);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAccountInfo";
            this.Size = new System.Drawing.Size(373, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalAccountsSum;
    }
}
