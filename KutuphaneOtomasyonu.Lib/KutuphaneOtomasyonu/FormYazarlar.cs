using KutuphaneOtomasyonu.Lib;
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
    public partial class FormYazarlar : Form
    {
        public FormYazarlar()
        {
            InitializeComponent();
        }




        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {

            Yazar yazar = new Yazar();
          

            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value;
            yazar.YazarTurler 

        }

        private void FormYazarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
