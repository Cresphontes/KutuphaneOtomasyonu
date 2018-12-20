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
            this.radioBtn7 = new System.Windows.Forms.RadioButton();
            this.radioBtn6 = new System.Windows.Forms.RadioButton();
            this.radioBtn5 = new System.Windows.Forms.RadioButton();
            this.radioBtn4 = new System.Windows.Forms.RadioButton();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
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
            this.cmbYazar.SelectedIndexChanged += new System.EventHandler(this.cmbYazar_SelectedIndexChanged);
            // 
            // gbTurler
            // 
            this.gbTurler.Controls.Add(this.radioBtn7);
            this.gbTurler.Controls.Add(this.radioBtn6);
            this.gbTurler.Controls.Add(this.radioBtn5);
            this.gbTurler.Controls.Add(this.radioBtn4);
            this.gbTurler.Controls.Add(this.radioBtn3);
            this.gbTurler.Controls.Add(this.radioBtn2);
            this.gbTurler.Controls.Add(this.radioBtn1);
            this.gbTurler.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTurler.Location = new System.Drawing.Point(12, 73);
            this.gbTurler.Name = "gbTurler";
            this.gbTurler.Size = new System.Drawing.Size(776, 90);
            this.gbTurler.TabIndex = 9;
            this.gbTurler.TabStop = false;
            this.gbTurler.Text = "Kitap Türü";
            // 
            // radioBtn7
            // 
            this.radioBtn7.AutoSize = true;
            this.radioBtn7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn7.Location = new System.Drawing.Point(674, 41);
            this.radioBtn7.Name = "radioBtn7";
            this.radioBtn7.Size = new System.Drawing.Size(64, 24);
            this.radioBtn7.TabIndex = 6;
            this.radioBtn7.TabStop = true;
            this.radioBtn7.Text = "Sanat";
            this.radioBtn7.UseVisualStyleBackColor = true;
            // 
            // radioBtn6
            // 
            this.radioBtn6.AutoSize = true;
            this.radioBtn6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn6.Location = new System.Drawing.Point(567, 41);
            this.radioBtn6.Name = "radioBtn6";
            this.radioBtn6.Size = new System.Drawing.Size(74, 24);
            this.radioBtn6.TabIndex = 5;
            this.radioBtn6.TabStop = true;
            this.radioBtn6.Text = "Felsefe";
            this.radioBtn6.UseVisualStyleBackColor = true;
            // 
            // radioBtn5
            // 
            this.radioBtn5.AutoSize = true;
            this.radioBtn5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn5.Location = new System.Drawing.Point(460, 41);
            this.radioBtn5.Name = "radioBtn5";
            this.radioBtn5.Size = new System.Drawing.Size(82, 24);
            this.radioBtn5.TabIndex = 4;
            this.radioBtn5.TabStop = true;
            this.radioBtn5.Text = "Psikoloji";
            this.radioBtn5.UseVisualStyleBackColor = true;
            // 
            // radioBtn4
            // 
            this.radioBtn4.AutoSize = true;
            this.radioBtn4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn4.Location = new System.Drawing.Point(353, 41);
            this.radioBtn4.Name = "radioBtn4";
            this.radioBtn4.Size = new System.Drawing.Size(65, 24);
            this.radioBtn4.TabIndex = 3;
            this.radioBtn4.TabStop = true;
            this.radioBtn4.Text = "Mizah";
            this.radioBtn4.UseVisualStyleBackColor = true;
            // 
            // radioBtn3
            // 
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn3.Location = new System.Drawing.Point(246, 41);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(60, 24);
            this.radioBtn3.TabIndex = 2;
            this.radioBtn3.TabStop = true;
            this.radioBtn3.Text = "Tarih";
            this.radioBtn3.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn2.Location = new System.Drawing.Point(139, 41);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(84, 24);
            this.radioBtn2.TabIndex = 1;
            this.radioBtn2.TabStop = true;
            this.radioBtn2.Text = "Edebiyat";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtn1.Location = new System.Drawing.Point(32, 41);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(59, 24);
            this.radioBtn1.TabIndex = 0;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "Bilim";
            this.radioBtn1.UseVisualStyleBackColor = true;
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
            this.btnKitapKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
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
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
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
        private System.Windows.Forms.RadioButton radioBtn7;
        private System.Windows.Forms.RadioButton radioBtn6;
        private System.Windows.Forms.RadioButton radioBtn5;
        private System.Windows.Forms.RadioButton radioBtn4;
        private System.Windows.Forms.RadioButton radioBtn3;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.Button btnKitapGuncelle;
    }
}