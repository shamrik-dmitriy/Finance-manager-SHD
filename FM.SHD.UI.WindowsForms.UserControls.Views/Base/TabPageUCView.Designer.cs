
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
            this.flowLayoutPanelButtonsBlock = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).BeginInit();
            this.splitContainerDesktop.Panel1.SuspendLayout();
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
            // 
            // splitContainerDesktop.Panel1
            // 
            this.splitContainerDesktop.Panel1.Controls.Add(this.flowLayoutPanelButtonsBlock);
            this.splitContainerDesktop.Panel1MinSize = 27;
            this.splitContainerDesktop.Size = new System.Drawing.Size(481, 291);
            this.splitContainerDesktop.SplitterDistance = 137;
            this.splitContainerDesktop.TabIndex = 4;
            // 
            // flowLayoutPanelButtonsBlock
            // 
            this.flowLayoutPanelButtonsBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtonsBlock.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtonsBlock.Name = "flowLayoutPanelButtonsBlock";
            this.flowLayoutPanelButtonsBlock.Size = new System.Drawing.Size(481, 137);
            this.flowLayoutPanelButtonsBlock.TabIndex = 0;
            // 
            // TabPageUCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.splitContainerDesktop);
            this.Name = "TabPageUCView";
            this.Size = new System.Drawing.Size(481, 291);
            this.Load += new System.EventHandler(this.TabPageUCView_Load);
            this.splitContainerDesktop.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDesktop)).EndInit();
            this.splitContainerDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDesktop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtonsBlock;
    }
}
