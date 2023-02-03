
namespace context_menu_strip_kulanımı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heaspMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.kolayErişimToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.maviToolStripMenuItem.Text = "mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.yeşilToolStripMenuItem.Text = "yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.cıkışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ayarlarToolStripMenuItem.Text = "ayarlar";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hakkımızdaToolStripMenuItem.Text = "hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // cıkışToolStripMenuItem
            // 
            this.cıkışToolStripMenuItem.Name = "cıkışToolStripMenuItem";
            this.cıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cıkışToolStripMenuItem.Text = "cıkış";
            this.cıkışToolStripMenuItem.Click += new System.EventHandler(this.cıkışToolStripMenuItem_Click);
            // 
            // kolayErişimToolStripMenuItem
            // 
            this.kolayErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heaspMakinesiToolStripMenuItem,
            this.pointToolStripMenuItem});
            this.kolayErişimToolStripMenuItem.Name = "kolayErişimToolStripMenuItem";
            this.kolayErişimToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kolayErişimToolStripMenuItem.Text = "kolay erişim ";
            // 
            // heaspMakinesiToolStripMenuItem
            // 
            this.heaspMakinesiToolStripMenuItem.Name = "heaspMakinesiToolStripMenuItem";
            this.heaspMakinesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.heaspMakinesiToolStripMenuItem.Text = "heasp makinesi";
            this.heaspMakinesiToolStripMenuItem.Click += new System.EventHandler(this.heaspMakinesiToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pointToolStripMenuItem.Text = "point ";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heaspMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
    }
}

