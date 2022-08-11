namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    partial class DescriptionTransactionUserControlView
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
            this.textBoxDescriptionTransaction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDescriptionTransaction
            // 
            this.textBoxDescriptionTransaction.Location = new System.Drawing.Point(0, 0);
            this.textBoxDescriptionTransaction.Multiline = true;
            this.textBoxDescriptionTransaction.Name = "textBoxDescriptionTransaction";
            this.textBoxDescriptionTransaction.PlaceholderText = "Введите описание транзакции";
            this.textBoxDescriptionTransaction.Size = new System.Drawing.Size(360, 59);
            this.textBoxDescriptionTransaction.TabIndex = 0;
            this.textBoxDescriptionTransaction.TextChanged += new System.EventHandler(this.textBoxDescriptionTransaction_TextChanged);
            // 
            // DescriptionTransactionUserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDescriptionTransaction);
            this.Name = "DescriptionTransactionUserControlView";
            this.Size = new System.Drawing.Size(360, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescriptionTransaction;
    }
}
