namespace KutuphaneOtomasyonu
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
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnKitapKayit = new System.Windows.Forms.Button();
            this.btnUyeKayit = new System.Windows.Forms.Button();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnYazarKayit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.açToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.açToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnKitapKayit
            // 
            this.btnKitapKayit.AutoEllipsis = true;
            this.btnKitapKayit.BackColor = System.Drawing.Color.Tomato;
            this.btnKitapKayit.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapKayit.Location = new System.Drawing.Point(31, 24);
            this.btnKitapKayit.Name = "btnKitapKayit";
            this.btnKitapKayit.Size = new System.Drawing.Size(432, 250);
            this.btnKitapKayit.TabIndex = 3;
            this.btnKitapKayit.Text = "KİTAP KAYIT";
            this.btnKitapKayit.UseVisualStyleBackColor = false;
            this.btnKitapKayit.Click += new System.EventHandler(this.btnKitapKayit_Click);
            // 
            // btnUyeKayit
            // 
            this.btnUyeKayit.AutoEllipsis = true;
            this.btnUyeKayit.BackColor = System.Drawing.Color.Tomato;
            this.btnUyeKayit.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeKayit.Location = new System.Drawing.Point(703, 24);
            this.btnUyeKayit.Name = "btnUyeKayit";
            this.btnUyeKayit.Size = new System.Drawing.Size(432, 250);
            this.btnUyeKayit.TabIndex = 4;
            this.btnUyeKayit.Text = "ÜYE KAYIT";
            this.btnUyeKayit.UseVisualStyleBackColor = false;
            this.btnUyeKayit.Click += new System.EventHandler(this.btnUyeKayit_Click);
            // 
            // btnKiralama
            // 
            this.btnKiralama.AutoEllipsis = true;
            this.btnKiralama.BackColor = System.Drawing.Color.Tomato;
            this.btnKiralama.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralama.Location = new System.Drawing.Point(703, 384);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(432, 250);
            this.btnKiralama.TabIndex = 5;
            this.btnKiralama.Text = "KİRALAMA";
            this.btnKiralama.UseVisualStyleBackColor = false;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnYazarKayit
            // 
            this.btnYazarKayit.AutoEllipsis = true;
            this.btnYazarKayit.BackColor = System.Drawing.Color.Tomato;
            this.btnYazarKayit.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarKayit.Location = new System.Drawing.Point(31, 384);
            this.btnYazarKayit.Name = "btnYazarKayit";
            this.btnYazarKayit.Size = new System.Drawing.Size(432, 250);
            this.btnYazarKayit.TabIndex = 7;
            this.btnYazarKayit.Text = "YAZAR KAYIT";
            this.btnYazarKayit.UseVisualStyleBackColor = false;
            this.btnYazarKayit.Click += new System.EventHandler(this.btnYazarKayit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnKiralama);
            this.panel1.Controls.Add(this.btnYazarKayit);
            this.panel1.Controls.Add(this.btnKitapKayit);
            this.panel1.Controls.Add(this.btnUyeKayit);
            this.panel1.Location = new System.Drawing.Point(377, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 691);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnKitapKayit;
        private System.Windows.Forms.Button btnUyeKayit;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.Button btnYazarKayit;
        private System.Windows.Forms.Panel panel1;
    }
}

