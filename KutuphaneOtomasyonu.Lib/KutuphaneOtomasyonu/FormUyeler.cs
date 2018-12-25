using KutuphaneOtomasyonu.Lib;
using KutuphaneOtomasyonu.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FormUyeler : Form
    {
        public FormUyeler()
        {

            InitializeComponent();
            context = Form1.context;
        }


        public static Context context { get; set; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {

            lstUyeler.Items.Clear();

            Uye uye = new Uye();

            uye.Ad = txtAd.Text;
            uye.Soyad = txtSoyad.Text;
            uye.Email = txtEmail.Text;
            uye.Telefon = txtTelefon.Text;
            uye.TCKN = txtTCKN.Text;


            context.Uyeler.Add(uye);

            lstUyeler.Items.AddRange(context.Uyeler.ToArray());


        }
    }
}
