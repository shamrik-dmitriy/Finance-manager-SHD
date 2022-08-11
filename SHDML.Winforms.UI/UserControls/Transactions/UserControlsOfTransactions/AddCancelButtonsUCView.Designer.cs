namespace SHDML.Winforms.UI.UserControls.Transactions.UserControlsOfTransactions
{
    partial class AddCancelButtonsUCView
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
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addedSingleTransactionButton = new System.Windows.Forms.Button();
            this.cancelSingleTransactionButton = new System.Windows.Forms.Button();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(354, 32);
            this.buttonsTableLayoutPanel.TabIndex = 15;
            // 
            // addedSingleTransactionButton
            // 
            this.addedSingleTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addedSingleTransactionButton.AutoSize = true;
            this.addedSingleTransactionButton.Location = new System.Drawing.Point(3, 3);
            this.addedSingleTransactionButton.Name = "addedSingleTransactionButton";
            this.addedSingleTransactionButton.Size = new System.Drawing.Size(112, 26);
            this.addedSingleTransactionButton.TabIndex = 0;
            this.addedSingleTransactionButton.Text = "Добавить";
            this.addedSingleTransactionButton.UseVisualStyleBackColor = true;
            // 
            // cancelSingleTransactionButton
            // 
            this.cancelSingleTransactionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelSingleTransactionButton.AutoSize = true;
            this.cancelSingleTransactionButton.Location = new System.Drawing.Point(239, 3);
            this.cancelSingleTransactionButton.Name = "cancelSingleTransactionButton";
            this.cancelSingleTransactionButton.Size = new System.Drawing.Size(112, 26);
            this.cancelSingleTransactionButton.TabIndex = 1;
            this.cancelSingleTransactionButton.Text = "Отмена";
            this.cancelSingleTransactionButton.UseVisualStyleBackColor = true;
            // 
            // AddCancelButtonsUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonsTableLayoutPanel);
            this.Name = "AddCancelButtonsUCView";
            this.Size = new System.Drawing.Size(360, 38);
            this.Load += new System.EventHandler(this.AddCancelUCView_Load);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.buttonsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addedSingleTransactionButton;
        private System.Windows.Forms.Button cancelSingleTransactionButton;
    }
}
