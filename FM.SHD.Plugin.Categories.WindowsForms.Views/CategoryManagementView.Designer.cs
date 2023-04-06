using System.ComponentModel;

namespace FM.SHD.Plugin.Categories.WindowsForms.Views
{
    partial class CategoryManagementView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCategory
            // 
            this.flowLayoutPanelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCategory.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCategory.Name = "flowLayoutPanelCategory";
            this.flowLayoutPanelCategory.Size = new System.Drawing.Size(366, 361);
            this.flowLayoutPanelCategory.TabIndex = 0;
            // 
            // CategoryManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 361);
            this.Controls.Add(this.flowLayoutPanelCategory);
            this.Name = "CategoryManagementView";
            this.Text = "CategoryManagementView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategory;
    }
}