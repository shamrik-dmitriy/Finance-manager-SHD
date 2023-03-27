
namespace FM.SHD.UI.WindowsForms.UserControls.Views.Base
{
    partial class TabPageUCView
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
            this.splitContainerDesktop = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).BeginInit();
            this.splitContainerDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerDesktop
            // 
            this.splitContainerDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDesktop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerDesktop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDesktop.Name = "splitContainerDesktop";
            this.splitContainerDesktop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerDesktop.Size = new System.Drawing.Size(0, 0);
            this.splitContainerDesktop.SplitterDistance = 25;
            this.splitContainerDesktop.TabIndex = 4;
            // 
            // TabPageUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainerDesktop);
            this.Name = "TabPageUCView";
            this.Size = new System.Drawing.Size(0, 0);
            this.Load += new System.EventHandler(this.TabPageUCView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).EndInit();
            this.splitContainerDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDesktop;
    }
}
