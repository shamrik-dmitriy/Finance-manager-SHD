
namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Additional.Transactions.UserControlsOfTransactions
{
    partial class ContrAgentUCView
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
            this.comboBoxContrAgentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxContrAgentName
            // 
            this.comboBoxContrAgentName.FormattingEnabled = true;
            this.comboBoxContrAgentName.Location = new System.Drawing.Point(124, 2);
            this.comboBoxContrAgentName.Name = "comboBoxContrAgentName";
            this.comboBoxContrAgentName.Size = new System.Drawing.Size(230, 23);
            this.comboBoxContrAgentName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Контрагент";
            // 
            // ContrAgentUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxContrAgentName);
            this.Controls.Add(this.label1);
            this.Name = "ContrAgentUCView";
            this.Size = new System.Drawing.Size(360, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContrAgentName;
        private System.Windows.Forms.Label label1;
    }
}
