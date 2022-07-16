
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
            this.debitAccountLabel = new System.Windows.Forms.Label();
            this.debitAccountComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // debitAccountLabel
            // 
            this.debitAccountLabel.AutoSize = true;
            this.debitAccountLabel.Location = new System.Drawing.Point(10, 6);
            this.debitAccountLabel.Name = "debitAccountLabel";
            this.debitAccountLabel.Size = new System.Drawing.Size(101, 15);
            this.debitAccountLabel.TabIndex = 3;
            this.debitAccountLabel.Text = "Списать со счёта";
            // 
            // debitAccountComboBox
            // 
            this.debitAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.debitAccountComboBox.FormattingEnabled = true;
            this.debitAccountComboBox.Location = new System.Drawing.Point(126, 3);
            this.debitAccountComboBox.Name = "debitAccountComboBox";
            this.debitAccountComboBox.Size = new System.Drawing.Size(230, 23);
            this.debitAccountComboBox.TabIndex = 2;
            // 
            // AccountInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debitAccountLabel);
            this.Controls.Add(this.debitAccountComboBox);
            this.Name = "AccountInfoUserControl";
            this.Size = new System.Drawing.Size(361, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label debitAccountLabel;
        private System.Windows.Forms.ComboBox debitAccountComboBox;
    }
}
