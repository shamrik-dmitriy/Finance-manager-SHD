
namespace FM.SHD.Winforms.UI.UserControls.Transactions.TransactionUserControls
{
    partial class TypeTransactionUCView
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
            this.typeTransactionLabel = new System.Windows.Forms.Label();
            this.typeOperationsCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // typeTransactionLabel
            // 
            this.typeTransactionLabel.AutoSize = true;
            this.typeTransactionLabel.Location = new System.Drawing.Point(3, 3);
            this.typeTransactionLabel.Name = "typeTransactionLabel";
            this.typeTransactionLabel.Size = new System.Drawing.Size(84, 15);
            this.typeTransactionLabel.TabIndex = 3;
            this.typeTransactionLabel.Text = "Тип операции";
            this.typeTransactionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // typeOperationsCombobox
            // 
            this.typeOperationsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOperationsCombobox.FormattingEnabled = true;
            this.typeOperationsCombobox.Location = new System.Drawing.Point(93, 0);
            this.typeOperationsCombobox.Name = "typeOperationsCombobox";
            this.typeOperationsCombobox.Size = new System.Drawing.Size(259, 23);
            this.typeOperationsCombobox.TabIndex = 2;
            this.typeOperationsCombobox.SelectedIndexChanged += new System.EventHandler(this.typeOperationsCombobox_SelectedIndexChanged);
            // 
            // TypeTransactionUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeTransactionLabel);
            this.Controls.Add(this.typeOperationsCombobox);
            this.Name = "TypeTransactionUCView";
            this.Size = new System.Drawing.Size(358, 23);
            this.Load += new System.EventHandler(this.TypeTransactionUserControlView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeTransactionLabel;
        protected internal System.Windows.Forms.ComboBox typeOperationsCombobox;
    }
}
