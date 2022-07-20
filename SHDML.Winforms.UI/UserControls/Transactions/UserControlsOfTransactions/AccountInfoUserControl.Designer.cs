
namespace SHDML.Winforms.UI.Transactions.SingleTransaction.SingleTransactionUserControls
{
    partial class AccountInfoUserControl
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
            this.infoAccountLabel = new System.Windows.Forms.Label();
            this.debitAccountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // infoAccountLabel
            // 
            this.infoAccountLabel.AutoSize = true;
            this.infoAccountLabel.Location = new System.Drawing.Point(10, 5);
            this.infoAccountLabel.Name = "infoAccountLabel";
            this.infoAccountLabel.Size = new System.Drawing.Size(108, 15);
            this.infoAccountLabel.TabIndex = 3;
            this.infoAccountLabel.Text = "Зачислить на счёт";
            // 
            // debitAccountComboBox
            // 
            this.debitAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.debitAccountComboBox.FormattingEnabled = true;
            this.debitAccountComboBox.Location = new System.Drawing.Point(124, 2);
            this.debitAccountComboBox.Name = "debitAccountComboBox";
            this.debitAccountComboBox.Size = new System.Drawing.Size(230, 23);
            this.debitAccountComboBox.TabIndex = 2;
            // 
            // AccountInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.infoAccountLabel);
            this.Controls.Add(this.debitAccountComboBox);
            this.Name = "AccountInfoUserControl";
            this.Size = new System.Drawing.Size(360, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoAccountLabel;
        private System.Windows.Forms.ComboBox debitAccountComboBox;
    }
}
