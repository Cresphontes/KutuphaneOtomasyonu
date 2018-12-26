namespace KutuphaneOtomasyonu
{
    partial class FormKitaplar
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
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.lblYayin = new System.Windows.Forms.Label();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.gbTurler = new System.Windows.Forms.GroupBox();
            this.Sanat = new System.Windows.Forms.RadioButton();
            this.Felsefe = new System.Windows.Forms.RadioButton();
            this.Psikoloji = new System.Windows.Forms.RadioButton();
            this.Mizah = new System.Windows.Forms.RadioButton();
            this.Tarih = new System.Windows.Forms.RadioButton();
            this.Edebiyat = new System.Windows.Forms.RadioButton();
            this.Bilim = new System.Windows.Forms.RadioButton();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvKitaplar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yazar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yayin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kaydetKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.acKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTurler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(356, 117);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(149, 20);
            this.txtKitapAd.TabIndex = 0;
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAd.Location = new System.Drawing.Point(390, 92);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(78, 22);
            this.lblKitapAd.TabIndex = 4;
            this.lblKitapAd.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(311, 278);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(53, 22);
            this.lblYazar.TabIndex = 5;
            this.lblYazar.Text = "Yazar";
            // 
            // txtYayin
            // 
            this.txtYayin.Location = new System.Drawing.Point(465, 303);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(149, 20);
            this.txtYayin.TabIndex = 6;
            // 
            // lblYayin
            // 
            this.lblYayin.AutoSize = true;
            this.lblYayin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayin.Location = new System.Drawing.Point(514, 278);
            this.lblYayin.Name = "lblYayin";
            this.lblYayin.Size = new System.Drawing.Size(50, 22);
            this.lblYayin.TabIndex = 7;
            this.lblYayin.Text = "Yayın";
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(264, 303);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(149, 21);
            this.cmbYazar.TabIndex = 8;
            this.cmbYazar.DropDown += new System.EventHandler(this.cmbYazar_DropDown);
            // 
            // gbTurler
            // 
            this.gbTurler.Controls.Add(this.Sanat);
            this.gbTurler.Controls.Add(this.Felsefe);
            this.gbTurler.Controls.Add(this.Psikoloji);
            this.gbTurler.Controls.Add(this.Mizah);
            this.gbTurler.Controls.Add(this.Tarih);
            this.gbTurler.Controls.Add(this.Edebiyat);
            this.gbTurler.Controls.Add(this.Bilim);
            this.gbTurler.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTurler.Location = new System.Drawing.Point(131, 162);
            this.gbTurler.Name = "gbTurler";
            this.gbTurler.Size = new System.Drawing.Size(611, 90);
            this.gbTurler.TabIndex = 9;
            this.gbTurler.TabStop = false;
            this.gbTurler.Text = "Kitap Türü";
            // 
            // Sanat
            // 
            this.Sanat.AutoSize = true;
            this.Sanat.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sanat.Location = new System.Drawing.Point(502, 42);
            this.Sanat.Name = "Sanat";
            this.Sanat.Size = new System.Drawing.Size(64, 24);
            this.Sanat.TabIndex = 6;
            this.Sanat.TabStop = true;
            this.Sanat.Text = "Sanat";
            this.Sanat.UseVisualStyleBackColor = true;
            // 
            // Felsefe
            // 
            this.Felsefe.AutoSize = true;
            this.Felsefe.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Felsefe.Location = new System.Drawing.Point(422, 42);
            this.Felsefe.Name = "Felsefe";
            this.Felsefe.Size = new System.Drawing.Size(74, 24);
            this.Felsefe.TabIndex = 5;
            this.Felsefe.TabStop = true;
            this.Felsefe.Text = "Felsefe";
            this.Felsefe.UseVisualStyleBackColor = true;
            // 
            // Psikoloji
            // 
            this.Psikoloji.AutoSize = true;
            this.Psikoloji.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Psikoloji.Location = new System.Drawing.Point(334, 42);
            this.Psikoloji.Name = "Psikoloji";
            this.Psikoloji.Size = new System.Drawing.Size(82, 24);
            this.Psikoloji.TabIndex = 4;
            this.Psikoloji.TabStop = true;
            this.Psikoloji.Text = "Psikoloji";
            this.Psikoloji.UseVisualStyleBackColor = true;
            // 
            // Mizah
            // 
            this.Mizah.AutoSize = true;
            this.Mizah.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mizah.Location = new System.Drawing.Point(263, 42);
            this.Mizah.Name = "Mizah";
            this.Mizah.Size = new System.Drawing.Size(65, 24);
            this.Mizah.TabIndex = 3;
            this.Mizah.TabStop = true;
            this.Mizah.Text = "Mizah";
            this.Mizah.UseVisualStyleBackColor = true;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih.Location = new System.Drawing.Point(197, 42);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(60, 24);
            this.Tarih.TabIndex = 2;
            this.Tarih.TabStop = true;
            this.Tarih.Text = "Tarih";
            this.Tarih.UseVisualStyleBackColor = true;
            // 
            // Edebiyat
            // 
            this.Edebiyat.AutoSize = true;
            this.Edebiyat.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Edebiyat.Location = new System.Drawing.Point(107, 42);
            this.Edebiyat.Name = "Edebiyat";
            this.Edebiyat.Size = new System.Drawing.Size(84, 24);
            this.Edebiyat.TabIndex = 1;
            this.Edebiyat.TabStop = true;
            this.Edebiyat.Text = "Edebiyat";
            this.Edebiyat.UseVisualStyleBackColor = true;
            // 
            // Bilim
            // 
            this.Bilim.AutoSize = true;
            this.Bilim.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilim.Location = new System.Drawing.Point(42, 42);
            this.Bilim.Name = "Bilim";
            this.Bilim.Size = new System.Drawing.Size(59, 24);
            this.Bilim.TabIndex = 0;
            this.Bilim.TabStop = true;
            this.Bilim.Text = "Bilim";
            this.Bilim.UseVisualStyleBackColor = true;
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.AutoEllipsis = true;
            this.btnKitapKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKitapKaydet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapKaydet.Location = new System.Drawing.Point(332, 358);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(101, 43);
            this.btnKitapKaydet.TabIndex = 11;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = false;
            this.btnKitapKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.AutoEllipsis = true;
            this.btnKitapGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(450, 358);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(101, 43);
            this.btnKitapGuncelle.TabIndex = 12;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(352, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kitap Kayıt";
            // 
            // lvKitaplar
            // 
            this.lvKitaplar.CheckBoxes = true;
            this.lvKitaplar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Ad,
            this.Yazar,
            this.Tur,
            this.Yayin});
            this.lvKitaplar.Location = new System.Drawing.Point(83, 425);
            this.lvKitaplar.Name = "lvKitaplar";
            this.lvKitaplar.Size = new System.Drawing.Size(714, 247);
            this.lvKitaplar.TabIndex = 30;
            this.lvKitaplar.UseCompatibleStateImageBehavior = false;
            this.lvKitaplar.View = System.Windows.Forms.View.Details;
            this.lvKitaplar.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvKitaplar_ItemCheck);
            
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
            this.Ad.Width = 162;
            // 
            // Yazar
            // 
            this.Yazar.Text = "Yazar";
            this.Yazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Yazar.Width = 194;
            // 
            // Tur
            // 
            this.Tur.Text = "Tür";
            this.Tur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tur.Width = 116;
            // 
            // Yayin
            // 
            this.Yayin.Text = "Yayın";
            this.Yayin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Yayin.Width = 284;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lvKitaplar);
            this.panel1.Controls.Add(this.txtKitapAd);
            this.panel1.Controls.Add(this.lblKitapAd);
            this.panel1.Controls.Add(this.btnKitapGuncelle);
            this.panel1.Controls.Add(this.lblYazar);
            this.panel1.Controls.Add(this.btnKitapKaydet);
            this.panel1.Controls.Add(this.txtYayin);
            this.panel1.Controls.Add(this.gbTurler);
            this.panel1.Controls.Add(this.lblYayin);
            this.panel1.Controls.Add(this.cmbYazar);
            this.panel1.Location = new System.Drawing.Point(527, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 712);
            this.panel1.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetKitap,
            this.acKitap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.acKitap;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kaydetKitap
            // 
            this.kaydetKitap.Name = "kaydetKitap";
            this.kaydetKitap.Size = new System.Drawing.Size(55, 20);
            this.kaydetKitap.Text = "Kaydet";
            this.kaydetKitap.Click += new System.EventHandler(this.kaydetKitap_Click);
            // 
            // acKitap
            // 
            this.acKitap.Name = "acKitap";
            this.acKitap.Size = new System.Drawing.Size(33, 20);
            this.acKitap.Text = "Aç";
            this.acKitap.Click += new System.EventHandler(this.acKitap_Click);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FormKitaplar";
            this.Text = "FormKitaplar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.gbTurler.ResumeLayout(false);
            this.gbTurler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.Label lblYayin;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.GroupBox gbTurler;
        private System.Windows.Forms.RadioButton Sanat;
        private System.Windows.Forms.RadioButton Felsefe;
        private System.Windows.Forms.RadioButton Psikoloji;
        private System.Windows.Forms.RadioButton Mizah;
        private System.Windows.Forms.RadioButton Tarih;
        private System.Windows.Forms.RadioButton Edebiyat;
        private System.Windows.Forms.RadioButton Bilim;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvKitaplar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Yazar;
        private System.Windows.Forms.ColumnHeader Tur;
        private System.Windows.Forms.ColumnHeader Yayin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetKitap;
        private System.Windows.Forms.ToolStripMenuItem acKitap;
    }
}