using KutuphaneOtomasyonu.Lib.Data;
using KutuphaneOtomasyonu.Lib.Helper;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        FormKitaplar frmKitaplar;
        FormUyeler frmUyeler;
        FormKiralama frmKiralama;
        FormYazarlar frmYazarlar;
        


        private void btnKitapKayit_Click(object sender, EventArgs e)
        {
            frmKitaplar = new FormKitaplar();
            frmKitaplar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tur tur = new Tur();


        }

        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            frmUyeler = new FormUyeler();
            frmUyeler.Show();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            frmKiralama = new FormKiralama();
            frmKiralama.Show();
        }

        private void btnYazarKayit_Click(object sender, EventArgs e)
        {
            frmYazarlar = new FormYazarlar();
            frmYazarlar.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            

        }
    }
}
