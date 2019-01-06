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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYazarlar));
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
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYazarSoyad
            // 
            resources.ApplyResources(this.lblYazarSoyad, "lblYazarSoyad");
            this.lblYazarSoyad.Name = "lblYazarSoyad";
            // 
            // txtYazarSoyad
            // 
            resources.ApplyResources(this.txtYazarSoyad, "txtYazarSoyad");
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            // 
            // lblYazar
            // 
            resources.ApplyResources(this.lblYazar, "lblYazar");
            this.lblYazar.Name = "lblYazar";
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.AutoEllipsis = true;
            this.btnYazarGuncelle.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnYazarGuncelle, "btnYazarGuncelle");
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = false;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Sanat
            // 
            resources.ApplyResources(this.Sanat, "Sanat");
            this.Sanat.Name = "Sanat";
            this.Sanat.UseVisualStyleBackColor = true;
            // 
            // Felsefe
            // 
            resources.ApplyResources(this.Felsefe, "Felsefe");
            this.Felsefe.Name = "Felsefe";
            this.Felsefe.UseVisualStyleBackColor = true;
            // 
            // Psikoloji
            // 
            resources.ApplyResources(this.Psikoloji, "Psikoloji");
            this.Psikoloji.Name = "Psikoloji";
            this.Psikoloji.UseVisualStyleBackColor = true;
            // 
            // Mizah
            // 
            resources.ApplyResources(this.Mizah, "Mizah");
            this.Mizah.Name = "Mizah";
            this.Mizah.UseVisualStyleBackColor = true;
            // 
            // Tarih
            // 
            resources.ApplyResources(this.Tarih, "Tarih");
            this.Tarih.Name = "Tarih";
            this.Tarih.UseVisualStyleBackColor = true;
            // 
            // Edebiyat
            // 
            resources.ApplyResources(this.Edebiyat, "Edebiyat");
            this.Edebiyat.Name = "Edebiyat";
            this.Edebiyat.UseVisualStyleBackColor = true;
            // 
            // Bilim
            // 
            resources.ApplyResources(this.Bilim, "Bilim");
            this.Bilim.Name = "Bilim";
            this.Bilim.UseVisualStyleBackColor = true;
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.AutoEllipsis = true;
            this.btnYazarKaydet.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.btnYazarKaydet, "btnYazarKaydet");
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = false;
            this.btnYazarKaydet.Click += new System.EventHandler(this.btnYazarKaydet_Click_1);
            // 
            // dtYazarDogumTarihi
            // 
            resources.ApplyResources(this.dtYazarDogumTarihi, "dtYazarDogumTarihi");
            this.dtYazarDogumTarihi.Name = "dtYazarDogumTarihi";
            // 
            // lblYazarAd
            // 
            resources.ApplyResources(this.lblYazarAd, "lblYazarAd");
            this.lblYazarAd.Name = "lblYazarAd";
            // 
            // lblYazarDogumTarihi
            // 
            resources.ApplyResources(this.lblYazarDogumTarihi, "lblYazarDogumTarihi");
            this.lblYazarDogumTarihi.Name = "lblYazarDogumTarihi";
            // 
            // txtYazarAd
            // 
            resources.ApplyResources(this.txtYazarAd, "txtYazarAd");
            this.txtYazarAd.Name = "txtYazarAd";
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
            this.lvYazarlar.FullRowSelect = true;
            resources.ApplyResources(this.lvYazarlar, "lvYazarlar");
            this.lvYazarlar.Name = "lvYazarlar";
            this.lvYazarlar.UseCompatibleStateImageBehavior = false;
            this.lvYazarlar.View = System.Windows.Forms.View.Details;
            this.lvYazarlar.SelectedIndexChanged += new System.EventHandler(this.lvYazarlar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // Ad
            // 
            resources.ApplyResources(this.Ad, "Ad");
            // 
            // Soyad
            // 
            resources.ApplyResources(this.Soyad, "Soyad");
            // 
            // DogumTarihi
            // 
            resources.ApplyResources(this.DogumTarihi, "DogumTarihi");
            // 
            // Tur1
            // 
            resources.ApplyResources(this.Tur1, "Tur1");
            // 
            // Tur2
            // 
            resources.ApplyResources(this.Tur2, "Tur2");
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // FormYazarlar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FormYazarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormYazarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ColumnHeader Tur2;
    }
}