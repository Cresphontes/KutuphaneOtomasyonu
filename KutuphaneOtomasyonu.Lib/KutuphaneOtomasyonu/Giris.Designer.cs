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
            this.BtnKitapKayit = new System.Windows.Forms.Button();
            this.btnUyeKayit = new System.Windows.Forms.Button();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.açToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnKitapKayit
            // 
            this.BtnKitapKayit.AutoEllipsis = true;
            this.BtnKitapKayit.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapKayit.Location = new System.Drawing.Point(145, 76);
            this.BtnKitapKayit.Name = "BtnKitapKayit";
            this.BtnKitapKayit.Size = new System.Drawing.Size(208, 121);
            this.BtnKitapKayit.TabIndex = 3;
            this.BtnKitapKayit.Text = "KİTAP KAYIT";
            this.BtnKitapKayit.UseVisualStyleBackColor = true;
            this.BtnKitapKayit.Click += new System.EventHandler(this.BtnKitapKayit_Click);
            // 
            // btnUyeKayit
            // 
            this.btnUyeKayit.AutoEllipsis = true;
            this.btnUyeKayit.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeKayit.Location = new System.Drawing.Point(447, 76);
            this.btnUyeKayit.Name = "btnUyeKayit";
            this.btnUyeKayit.Size = new System.Drawing.Size(208, 121);
            this.btnUyeKayit.TabIndex = 4;
            this.btnUyeKayit.Text = "ÜYE KAYIT";
            this.btnUyeKayit.UseVisualStyleBackColor = true;
            this.btnUyeKayit.Click += new System.EventHandler(this.btnUyeKayit_Click);
            // 
            // btnKiralama
            // 
            this.btnKiralama.AutoEllipsis = true;
            this.btnKiralama.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralama.Location = new System.Drawing.Point(292, 253);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(208, 121);
            this.btnKiralama.TabIndex = 5;
            this.btnKiralama.Text = "KİRALAMA";
            this.btnKiralama.UseVisualStyleBackColor = true;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnKiralama);
            this.Controls.Add(this.btnUyeKayit);
            this.Controls.Add(this.BtnKitapKayit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BtnKitapKayit;
        private System.Windows.Forms.Button btnUyeKayit;
        private System.Windows.Forms.Button btnKiralama;
    }
}

