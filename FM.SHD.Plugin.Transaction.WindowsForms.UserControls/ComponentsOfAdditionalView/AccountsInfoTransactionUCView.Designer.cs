
namespace FM.SHD.Plugin.Transaction.WindowsForms.UserControls.ComponentsOfAdditionalView
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
            this.SuspendLayout();
            // 
            // financeInfoOfOperationflowLayoutPanel
            // 
            this.financeInfoOfOperationflowLayoutPanel.AutoSize = true;
            this.financeInfoOfOperationflowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.financeInfoOfOperationflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeInfoOfOperationflowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.financeInfoOfOperationflowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.financeInfoOfOperationflowLayoutPanel.Name = "financeInfoOfOperationflowLayoutPanel";
            this.financeInfoOfOperationflowLayoutPanel.Size = new System.Drawing.Size(355, 150);
            this.financeInfoOfOperationflowLayoutPanel.TabIndex = 8;
            // 
            // AccountsInfoTransactionUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.financeInfoOfOperationflowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(355, 150);
            this.Name = "AccountsInfoTransactionUCView";
            this.Size = new System.Drawing.Size(355, 150);
            this.Load += new System.EventHandler(this.AccountsInfoTransactionUCView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel financeInfoOfOperationflowLayoutPanel;
    }
}
