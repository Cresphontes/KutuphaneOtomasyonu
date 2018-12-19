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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.lblYayin = new System.Windows.Forms.Label();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.gbTurler = new System.Windows.Forms.GroupBox();
            this.radioBtnBilim = new System.Windows.Forms.RadioButton();
            this.radioBtnEdebiyat = new System.Windows.Forms.RadioButton();
            this.radioBtnTarih = new System.Windows.Forms.RadioButton();
            this.radioBtnMizah = new System.Windows.Forms.RadioButton();
            this.radioBtnPsikoloji = new System.Windows.Forms.RadioButton();
            this.radioBtnFelsefe = new System.Windows.Forms.RadioButton();
            this.radioBtnSanat = new System.Windows.Forms.RadioButton();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.gbTurler.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(307, 34);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(149, 20);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(341, 9);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(78, 22);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(260, 176);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(53, 22);
            this.lblYazar.TabIndex = 5;
            this.lblYazar.Text = "Yazar";
            // 
            // txtYayin
            // 
            this.txtYayin.Location = new System.Drawing.Point(419, 201);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(149, 20);
            this.txtYayin.TabIndex = 6;
            // 
            // lblYayin
            // 
            this.lblYayin.AutoSize = true;
            this.lblYayin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayin.Location = new System.Drawing.Point(468, 176);
            this.lblYayin.Name = "lblYayin";
            this.lblYayin.Size = new System.Drawing.Size(50, 22);
            this.lblYayin.TabIndex = 7;
            this.lblYayin.Text = "Yayın";
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(213, 201);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(149, 21);
            this.cmbYazar.TabIndex = 8;
            // 
            // gbTurler
            // 
            this.gbTurler.Controls.Add(this.radioBtnSanat);
            this.gbTurler.Controls.Add(this.radioBtnFelsefe);
            this.gbTurler.Controls.Add(this.radioBtnPsikoloji);
            this.gbTurler.Controls.Add(this.radioBtnMizah);
            this.gbTurler.Controls.Add(this.radioBtnTarih);
            this.gbTurler.Controls.Add(this.radioBtnEdebiyat);
            this.gbTurler.Controls.Add(this.radioBtnBilim);
            this.gbTurler.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTurler.Location = new System.Drawing.Point(12, 73);
            this.gbTurler.Name = "gbTurler";
            this.gbTurler.Size = new System.Drawing.Size(776, 90);
            this.gbTurler.TabIndex = 9;
            this.gbTurler.TabStop = false;
            this.gbTurler.Text = "Kitap Türü";
            // 
            // radioBtnBilim
            // 
            this.radioBtnBilim.AutoSize = true;
            this.radioBtnBilim.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnBilim.Location = new System.Drawing.Point(32, 41);
            this.radioBtnBilim.Name = "radioBtnBilim";
            this.radioBtnBilim.Size = new System.Drawing.Size(59, 24);
            this.radioBtnBilim.TabIndex = 0;
            this.radioBtnBilim.TabStop = true;
            this.radioBtnBilim.Text = "Bilim";
            this.radioBtnBilim.UseVisualStyleBackColor = true;
            // 
            // radioBtnEdebiyat
            // 
            this.radioBtnEdebiyat.AutoSize = true;
            this.radioBtnEdebiyat.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnEdebiyat.Location = new System.Drawing.Point(139, 41);
            this.radioBtnEdebiyat.Name = "radioBtnEdebiyat";
            this.radioBtnEdebiyat.Size = new System.Drawing.Size(84, 24);
            this.radioBtnEdebiyat.TabIndex = 1;
            this.radioBtnEdebiyat.TabStop = true;
            this.radioBtnEdebiyat.Text = "Edebiyat";
            this.radioBtnEdebiyat.UseVisualStyleBackColor = true;
            // 
            // radioBtnTarih
            // 
            this.radioBtnTarih.AutoSize = true;
            this.radioBtnTarih.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnTarih.Location = new System.Drawing.Point(246, 41);
            this.radioBtnTarih.Name = "radioBtnTarih";
            this.radioBtnTarih.Size = new System.Drawing.Size(60, 24);
            this.radioBtnTarih.TabIndex = 2;
            this.radioBtnTarih.TabStop = true;
            this.radioBtnTarih.Text = "Tarih";
            this.radioBtnTarih.UseVisualStyleBackColor = true;
            // 
            // radioBtnMizah
            // 
            this.radioBtnMizah.AutoSize = true;
            this.radioBtnMizah.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnMizah.Location = new System.Drawing.Point(353, 41);
            this.radioBtnMizah.Name = "radioBtnMizah";
            this.radioBtnMizah.Size = new System.Drawing.Size(65, 24);
            this.radioBtnMizah.TabIndex = 3;
            this.radioBtnMizah.TabStop = true;
            this.radioBtnMizah.Text = "Mizah";
            this.radioBtnMizah.UseVisualStyleBackColor = true;
            // 
            // radioBtnPsikoloji
            // 
            this.radioBtnPsikoloji.AutoSize = true;
            this.radioBtnPsikoloji.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnPsikoloji.Location = new System.Drawing.Point(460, 41);
            this.radioBtnPsikoloji.Name = "radioBtnPsikoloji";
            this.radioBtnPsikoloji.Size = new System.Drawing.Size(82, 24);
            this.radioBtnPsikoloji.TabIndex = 4;
            this.radioBtnPsikoloji.TabStop = true;
            this.radioBtnPsikoloji.Text = "Psikoloji";
            this.radioBtnPsikoloji.UseVisualStyleBackColor = true;
            // 
            // radioBtnFelsefe
            // 
            this.radioBtnFelsefe.AutoSize = true;
            this.radioBtnFelsefe.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnFelsefe.Location = new System.Drawing.Point(567, 41);
            this.radioBtnFelsefe.Name = "radioBtnFelsefe";
            this.radioBtnFelsefe.Size = new System.Drawing.Size(74, 24);
            this.radioBtnFelsefe.TabIndex = 5;
            this.radioBtnFelsefe.TabStop = true;
            this.radioBtnFelsefe.Text = "Felsefe";
            this.radioBtnFelsefe.UseVisualStyleBackColor = true;
            // 
            // radioBtnSanat
            // 
            this.radioBtnSanat.AutoSize = true;
            this.radioBtnSanat.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnSanat.Location = new System.Drawing.Point(674, 41);
            this.radioBtnSanat.Name = "radioBtnSanat";
            this.radioBtnSanat.Size = new System.Drawing.Size(64, 24);
            this.radioBtnSanat.TabIndex = 6;
            this.radioBtnSanat.TabStop = true;
            this.radioBtnSanat.Text = "Sanat";
            this.radioBtnSanat.UseVisualStyleBackColor = true;
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.Location = new System.Drawing.Point(105, 317);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(588, 121);
            this.lstKitaplar.TabIndex = 10;
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.AutoEllipsis = true;
            this.btnKitapKaydet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapKaydet.Location = new System.Drawing.Point(282, 253);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(101, 43);
            this.btnKitapKaydet.TabIndex = 11;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.AutoEllipsis = true;
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(405, 253);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(101, 43);
            this.btnKitapGuncelle.TabIndex = 12;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.btnKitapKaydet);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.gbTurler);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.lblYayin);
            this.Controls.Add(this.txtYayin);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.txtKitapAdi);
            this.Name = "FormKitaplar";
            this.Text = "FormKitaplar";
            this.gbTurler.ResumeLayout(false);
            this.gbTurler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.Label lblYayin;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.GroupBox gbTurler;
        private System.Windows.Forms.RadioButton radioBtnSanat;
        private System.Windows.Forms.RadioButton radioBtnFelsefe;
        private System.Windows.Forms.RadioButton radioBtnPsikoloji;
        private System.Windows.Forms.RadioButton radioBtnMizah;
        private System.Windows.Forms.RadioButton radioBtnTarih;
        private System.Windows.Forms.RadioButton radioBtnEdebiyat;
        private System.Windows.Forms.RadioButton radioBtnBilim;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.Button btnKitapGuncelle;
    }
}