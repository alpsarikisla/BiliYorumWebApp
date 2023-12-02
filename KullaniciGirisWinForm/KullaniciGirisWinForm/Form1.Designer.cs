namespace KullaniciGirisWinForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_BirinciFormAc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_IkınciFormAc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_BagimsizFormAc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formİşlemleriToolStripMenuItem
            // 
            this.formİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_BirinciFormAc,
            this.TSMI_IkınciFormAc,
            this.toolStripSeparator1,
            this.TSMI_BagimsizFormAc,
            this.TSMI_Kapat});
            this.formİşlemleriToolStripMenuItem.Name = "formİşlemleriToolStripMenuItem";
            this.formİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.formİşlemleriToolStripMenuItem.Text = "Form İşlemleri";
            // 
            // TSMI_BirinciFormAc
            // 
            this.TSMI_BirinciFormAc.Name = "TSMI_BirinciFormAc";
            this.TSMI_BirinciFormAc.Size = new System.Drawing.Size(180, 22);
            this.TSMI_BirinciFormAc.Text = "1. Formu Aç";
            this.TSMI_BirinciFormAc.Click += new System.EventHandler(this.TSMI_BirinciFormAc_Click);
            // 
            // TSMI_IkınciFormAc
            // 
            this.TSMI_IkınciFormAc.Name = "TSMI_IkınciFormAc";
            this.TSMI_IkınciFormAc.Size = new System.Drawing.Size(180, 22);
            this.TSMI_IkınciFormAc.Text = "2. Formu Aç";
            this.TSMI_IkınciFormAc.Click += new System.EventHandler(this.TSMI_IkınciFormAc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_BagimsizFormAc
            // 
            this.TSMI_BagimsizFormAc.Name = "TSMI_BagimsizFormAc";
            this.TSMI_BagimsizFormAc.Size = new System.Drawing.Size(180, 22);
            this.TSMI_BagimsizFormAc.Text = "Bağımsız Form Aç";
            this.TSMI_BagimsizFormAc.Click += new System.EventHandler(this.TSMI_BagimsizFormAc_Click);
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kapat.Text = "Kapat";
            this.TSMI_Kapat.Click += new System.EventHandler(this.TSMI_Kapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BirinciFormAc;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IkınciFormAc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_BagimsizFormAc;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
    }
}

