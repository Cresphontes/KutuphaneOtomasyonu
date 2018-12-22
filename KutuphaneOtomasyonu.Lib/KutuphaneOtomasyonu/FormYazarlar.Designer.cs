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
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.btnYazarKaydet = new System.Windows.Forms.Button();
            this.lstYazarlar = new System.Windows.Forms.ListBox();
            this.lblYazarAd = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.lblYazarSoyad = new System.Windows.Forms.Label();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtYazarDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblYazarDogumTarihi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.AutoEllipsis = true;
            this.btnYazarGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGuncelle.Location = new System.Drawing.Point(393, 290);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(101, 43);
            this.btnYazarGuncelle.TabIndex = 22;
            this.btnYazarGuncelle.Text = "Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYazarKaydet
            // 
            this.btnYazarKaydet.AutoEllipsis = true;
            this.btnYazarKaydet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarKaydet.Location = new System.Drawing.Point(270, 290);
            this.btnYazarKaydet.Name = "btnYazarKaydet";
            this.btnYazarKaydet.Size = new System.Drawing.Size(101, 43);
            this.btnYazarKaydet.TabIndex = 21;
            this.btnYazarKaydet.Text = "Kaydet";
            this.btnYazarKaydet.UseVisualStyleBackColor = true;
            this.btnYazarKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
            // 
            // lstYazarlar
            // 
            this.lstYazarlar.FormattingEnabled = true;
            this.lstYazarlar.Location = new System.Drawing.Point(105, 345);
            this.lstYazarlar.Name = "lstYazarlar";
            this.lstYazarlar.Size = new System.Drawing.Size(588, 95);
            this.lstYazarlar.TabIndex = 20;
            // 
            // lblYazarAd
            // 
            this.lblYazarAd.AutoSize = true;
            this.lblYazarAd.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarAd.Location = new System.Drawing.Point(263, 60);
            this.lblYazarAd.Name = "lblYazarAd";
            this.lblYazarAd.Size = new System.Drawing.Size(30, 22);
            this.lblYazarAd.TabIndex = 14;
            this.lblYazarAd.Text = "Ad";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(207, 85);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(149, 20);
            this.txtYazarAd.TabIndex = 13;
            // 
            // lblYazarSoyad
            // 
            this.lblYazarSoyad.AutoSize = true;
            this.lblYazarSoyad.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarSoyad.Location = new System.Drawing.Point(452, 60);
            this.lblYazarSoyad.Name = "lblYazarSoyad";
            this.lblYazarSoyad.Size = new System.Drawing.Size(54, 22);
            this.lblYazarSoyad.TabIndex = 24;
            this.lblYazarSoyad.Text = "Soyad";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(405, 85);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtYazarSoyad.TabIndex = 23;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(299, 9);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(156, 35);
            this.lblYazar.TabIndex = 25;
            this.lblYazar.Text = "Yazar Kayıt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(74, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 86);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Kitap Türleri";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(546, 40);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(70, 26);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Sanat";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(459, 40);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 26);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Felsefe";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(359, 40);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(94, 26);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Psikoloji";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(280, 40);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 26);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Mizah";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(207, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 26);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tarih";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(108, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 26);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Edebiyat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bilim";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtYazarDogumTarihi
            // 
            this.dtYazarDogumTarihi.Location = new System.Drawing.Point(282, 147);
            this.dtYazarDogumTarihi.Name = "dtYazarDogumTarihi";
            this.dtYazarDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtYazarDogumTarihi.TabIndex = 27;
            // 
            // lblYazarDogumTarihi
            // 
            this.lblYazarDogumTarihi.AutoSize = true;
            this.lblYazarDogumTarihi.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazarDogumTarihi.Location = new System.Drawing.Point(325, 122);
            this.lblYazarDogumTarihi.Name = "lblYazarDogumTarihi";
            this.lblYazarDogumTarihi.Size = new System.Drawing.Size(110, 22);
            this.lblYazarDogumTarihi.TabIndex = 28;
            this.lblYazarDogumTarihi.Text = "Doğum Tarihi";
            // 
            // FormYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYazarDogumTarihi);
            this.Controls.Add(this.dtYazarDogumTarihi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblYazarSoyad);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.btnYazarGuncelle);
            this.Controls.Add(this.btnYazarKaydet);
            this.Controls.Add(this.lstYazarlar);
            this.Controls.Add(this.lblYazarAd);
            this.Controls.Add(this.txtYazarAd);
            this.Name = "FormYazarlar";
            this.Text = "FormYazarlar";
            this.Load += new System.EventHandler(this.FormYazarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.Button btnYazarKaydet;
        private System.Windows.Forms.ListBox lstYazarlar;
        private System.Windows.Forms.Label lblYazarAd;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label lblYazarSoyad;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.DateTimePicker dtYazarDogumTarihi;
        private System.Windows.Forms.Label lblYazarDogumTarihi;
    }
}