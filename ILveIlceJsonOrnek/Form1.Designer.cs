
namespace ILveIlceJsonOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ıLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıLCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilIslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilceIslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıLToolStripMenuItem,
            this.ıLCEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ıLToolStripMenuItem
            // 
            this.ıLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilIslemlerToolStripMenuItem});
            this.ıLToolStripMenuItem.Name = "ıLToolStripMenuItem";
            this.ıLToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.ıLToolStripMenuItem.Text = "IL";
            // 
            // ıLCEToolStripMenuItem
            // 
            this.ıLCEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilceIslemlerToolStripMenuItem});
            this.ıLCEToolStripMenuItem.Name = "ıLCEToolStripMenuItem";
            this.ıLCEToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.ıLCEToolStripMenuItem.Text = "ILCE";
            // 
            // ilIslemlerToolStripMenuItem
            // 
            this.ilIslemlerToolStripMenuItem.Name = "ilIslemlerToolStripMenuItem";
            this.ilIslemlerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilIslemlerToolStripMenuItem.Text = "İl işlemler";
            // 
            // ilceIslemlerToolStripMenuItem
            // 
            this.ilceIslemlerToolStripMenuItem.Name = "ilceIslemlerToolStripMenuItem";
            this.ilceIslemlerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ilceIslemlerToolStripMenuItem.Text = "İlçe İşlemler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 536);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ıLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilIslemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıLCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilceIslemlerToolStripMenuItem;
    }
}

