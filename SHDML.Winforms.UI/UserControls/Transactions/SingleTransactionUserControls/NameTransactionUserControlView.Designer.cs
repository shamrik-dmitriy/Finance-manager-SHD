﻿namespace SHDML.Winforms.UI.UserControls.Transactions.SingleTransactionUserControls
{
    partial class NameTransactionUserControlView
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
            this.textBoxTransactionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTransactionName
            // 
            this.textBoxTransactionName.Location = new System.Drawing.Point(0, 2);
            this.textBoxTransactionName.Name = "textBoxTransactionName";
            this.textBoxTransactionName.PlaceholderText = "Введите наименование транзакции";
            this.textBoxTransactionName.Size = new System.Drawing.Size(359, 23);
            this.textBoxTransactionName.TabIndex = 0;
            this.textBoxTransactionName.TextChanged += new System.EventHandler(this.textBoxTransactionName_TextChanged);
            // 
            // NameTransactionUserControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTransactionName);
            this.Name = "NameTransactionUserControlView";
            this.Size = new System.Drawing.Size(360, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTransactionName;
    }
}
