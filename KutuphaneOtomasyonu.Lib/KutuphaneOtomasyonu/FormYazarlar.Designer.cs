namespace KutuphaneOtomasyonu
{
    partial class FormYazarlar
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
            this.lblYazarSoyad = new System.Windows.Forms.Label();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sanat = new System.Windows.Forms.CheckBox();
            this.Felsefe = new System.Windows.Forms.CheckBox();
            this.Psikoloji = new System.Windows.Forms.CheckBox();
            this.Mizah = new System.Windows.Forms.CheckBox();
            this.Tarih = new System.Windows.Forms.CheckBox();
            this.Edebiyat = new System.Windows.Forms.CheckBox();
            this.Bilim = new System.Windows.Forms.CheckBox();
            this.btnYazarKaydet = new System.Windows.Forms.Button();
            this.dtYazarDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblYazarAd = new System.Windows.Forms.Label();
            this.lblYazarDogumTarihi = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.lvYazarlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DogumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tur1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tur2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kaydetYazar = new System.Windows.Forms.ToolStripMenuItem();
            this.AcYazar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYazarSoyad
            // 
            this.lblYazarSoyad.AutoSize = true;
            this.lblYazarSoyad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarSoyad.Location = new System.Drawing.Point(537, 102);
            this.lblYazarSoyad.Name = "lblYazarSoyad";
            this.lblYazarSoyad.Size = new System.Drawing.Size(54, 22);
            this.lblYazarSoyad.TabIndex = 24;
            this.lblYazarSoyad.Text = "Soyad";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(490, 127);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtYazarSoyad.TabIndex = 23;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(378, 19);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(156, 35);
            this.lblYazar.TabIndex = 25;
            this.lblYazar.Text = "Yazar Kayıt";
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.AutoEllipsis = true;
            this.btnYazarGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnYazarGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGuncelle.Location = new System.Drawing.Point(490, 355);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(101, 43);
            this.btnYazarGuncelle.TabIndex = 22;
            this.btnYazarGuncelle.Text = "Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sanat);
            this.groupBox1.Controls.Add(this.Felsefe);
            this.groupBox1.Controls.Add(this.Psikoloji);
            this.groupBox1.Controls.Add(this.Mizah);
            this.groupBox1.Controls.Add(this.Tarih);
            this.groupBox1.Controls.Add(this.Edebiyat);
            this.groupBox1.Controls.Add(this.Bilim);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(115, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 86);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Kitap Türleri";
            // 
            // Sanat
            // 
            this.Sanat.AutoSize = true;
            this.Sanat.Location = new System.Drawing.Point(608, 43);
            this.Sanat.Name = "Sanat";
            this.Sanat.Size = new System.Drawing.Size(70, 26);
            this.Sanat.TabIndex = 6;
            this.Sanat.Text = "Sanat";
            this.Sanat.UseVisualStyleBackColor = true;
            // 
            // Felsefe
            // 
            this.Felsefe.AutoSize = true;
            this.Felsefe.Location = new System.Drawing.Point(521, 43);
            this.Felsefe.Name = "Felsefe";
            this.Felsefe.Size = new System.Drawing.Size(81, 26);
            this.Felsefe.TabIndex = 5;
            this.Felsefe.Text = "Felsefe";
            this.Felsefe.UseVisualStyleBackColor = true;
            // 
            // Psikoloji
            // 
            this.Psikoloji.AutoSize = true;
            this.Psikoloji.Location = new System.Drawing.Point(421, 43);
            this.Psikoloji.Name = "Psikoloji";
            this.Psikoloji.Size = new System.Drawing.Size(94, 26);
            this.Psikoloji.TabIndex = 4;
            this.Psikoloji.Text = "Psikoloji";
            this.Psikoloji.UseVisualStyleBackColor = true;
            // 
            // Mizah
            // 
            this.Mizah.AutoSize = true;
            this.Mizah.Location = new System.Drawing.Point(342, 43);
            this.Mizah.Name = "Mizah";
            this.Mizah.Size = new System.Drawing.Size(73, 26);
            this.Mizah.TabIndex = 3;
            this.Mizah.Text = "Mizah";
            this.Mizah.UseVisualStyleBackColor = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Location = new System.Drawing.Point(269, 43);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(67, 26);
            this.Tarih.TabIndex = 2;
            this.Tarih.Text = "Tarih";
            this.Tarih.UseVisualStyleBackColor = true;
            // 
            // Edebiyat
            // 
            this.Edebiyat.AutoSize = true;
            this.Edebiyat.Location = new System.Drawing.Point(170, 43);
            this.Edebiyat.Name = "Edebiyat";
            this.Edebiyat.Size = new System.Drawing.Size(93, 26);
            this.Edebiyat.TabIndex = 1;
            this.Edebiyat.Text = "Edebiyat";
            this.Edebiyat.UseVisualStyleBackColor = true;
            // 
            // Bilim
            // 
            this.Bilim.AutoSize = true;
            this.Bilim.Location = new System.Drawing.Point(97, 43);
            this.Bilim.Name = "Bilim";
            this.Bilim.Size = new System.Drawing.Size(67, 26);
            this.Bilim.TabIndex = 0;
            this.Bilim.Text = "Bilim";
            this.Bilim.UseVisualStyleBackColor = true;
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.AutoEllipsis = true;
            this.btnYazarKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnYazarKaydet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarKaydet.Location = new System.Drawing.Point(352, 355);
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.Size = new System.Drawing.Size(101, 43);
            this.btnYazarKaydet.TabIndex = 21;
            this.btnYazarKaydet.Text = "Kaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = false;
            this.btnYazarKaydet.Click += new System.EventHandler(this.btnYazarKaydet_Click_1);
            // 
            // dtYazarDogumTarihi
            // 
            this.dtYazarDogumTarihi.Location = new System.Drawing.Point(367, 189);
            this.dtYazarDogumTarihi.Name = "dtYazarDogumTarihi";
            this.dtYazarDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtYazarDogumTarihi.TabIndex = 27;
            // 
            // lblYazarAd
            // 
            this.lblYazarAd.AutoSize = true;
            this.lblYazarAd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAd.Location = new System.Drawing.Point(348, 102);
            this.lblYazarAd.Name = "lblYazarAd";
            this.lblYazarAd.Size = new System.Drawing.Size(30, 22);
            this.lblYazarAd.TabIndex = 14;
            this.lblYazarAd.Text = "Ad";
            // 
            // lblYazarDogumTarihi
            // 
            this.lblYazarDogumTarihi.AutoSize = true;
            this.lblYazarDogumTarihi.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarDogumTarihi.Location = new System.Drawing.Point(410, 164);
            this.lblYazarDogumTarihi.Name = "lblYazarDogumTarihi";
            this.lblYazarDogumTarihi.Size = new System.Drawing.Size(110, 22);
            this.lblYazarDogumTarihi.TabIndex = 28;
            this.lblYazarDogumTarihi.Text = "Doğum Tarihi";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(292, 127);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(149, 20);
            this.txtYazarAd.TabIndex = 13;
            // 
            // lvYazarlar
            // 
            this.lvYazarlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Ad,
            this.Soyad,
            this.DogumTarihi,
            this.Tur1,
            this.Tur2});
            this.lvYazarlar.Location = new System.Drawing.Point(81, 433);
            this.lvYazarlar.Name = "lvYazarlar";
            this.lvYazarlar.Size = new System.Drawing.Size(785, 286);
            this.lvYazarlar.TabIndex = 29;
            this.lvYazarlar.UseCompatibleStateImageBehavior = false;
            this.lvYazarlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 24;
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            this.Ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            this.Soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Soyad.Width = 146;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Text = "Doğum Tarihi";
            this.DogumTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DogumTarihi.Width = 201;
            // 
            // Tur1
            // 
            this.Tur1.Text = "Tür 1";
            this.Tur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tur1.Width = 155;
            // 
            // Tur2
            // 
            this.Tur2.Text = "Tür 2";
            this.Tur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tur2.Width = 92;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblYazar);
            this.panel1.Controls.Add(this.lvYazarlar);
            this.panel1.Controls.Add(this.txtYazarAd);
            this.panel1.Controls.Add(this.lblYazarDogumTarihi);
            this.panel1.Controls.Add(this.lblYazarAd);
            this.panel1.Controls.Add(this.dtYazarDogumTarihi);
            this.panel1.Controls.Add(this.btnYazarKaydet);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnYazarGuncelle);
            this.panel1.Controls.Add(this.txtYazarSoyad);
            this.panel1.Controls.Add(this.lblYazarSoyad);
            this.panel1.Location = new System.Drawing.Point(498, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 736);
            this.panel1.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetYazar,
            this.AcYazar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.AcYazar;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kaydetYazar
            // 
            this.kaydetYazar.Name = "kaydetYazar";
            this.kaydetYazar.Size = new System.Drawing.Size(55, 20);
            this.kaydetYazar.Text = "Kaydet";
            // 
            // AcYazar
            // 
            this.AcYazar.Name = "AcYazar";
            this.AcYazar.Size = new System.Drawing.Size(33, 20);
            this.AcYazar.Text = "Aç";
            // 
            // FormYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 900);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FormYazarlar";
            this.Text = "FormYazarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormYazarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazarSoyad;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Sanat;
        private System.Windows.Forms.CheckBox Felsefe;
        private System.Windows.Forms.CheckBox Psikoloji;
        private System.Windows.Forms.CheckBox Mizah;
        private System.Windows.Forms.CheckBox Tarih;
        private System.Windows.Forms.CheckBox Edebiyat;
        private System.Windows.Forms.CheckBox Bilim;
        private System.Windows.Forms.Button btnYazarKaydet;
        private System.Windows.Forms.DateTimePicker dtYazarDogumTarihi;
        private System.Windows.Forms.Label lblYazarAd;
        private System.Windows.Forms.Label lblYazarDogumTarihi;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.ListView lvYazarlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader DogumTarihi;
        private System.Windows.Forms.ColumnHeader Tur1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetYazar;
        private System.Windows.Forms.ToolStripMenuItem AcYazar;
        private System.Windows.Forms.ColumnHeader Tur2;
    }
}