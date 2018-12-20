using KutuphaneOtomasyonu.Lib;
using KutuphaneOtomasyonu.Lib.Business;
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
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
        }

        List<RadioButton> radioButtons { get; set; } = new List<RadioButton>();
        List<KitapTurler> turler = new List<KitapTurler>();
       
        

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            foreach (var item in radioButtons)
            {
                if (item.Checked == true)
                {

                }
            }

            YazarBusiness yazarBusiness = new YazarBusiness();

            Yazar yazar = cmbYazar.SelectedItem as Yazar;

            Kitap kitap = new Kitap()
            {
                KitapAd = txtKitapAdi.Text,
               
            }
           



            yazarBusiness.AtamaYapKitapYazar(yazar, kitap);

        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            radioButtons = new List<RadioButton>() { radioBtn1, radioBtn2, radioBtn3, radioBtn4, radioBtn5, radioBtn6, radioBtn7 };
            turler.AddRange((KitapTurler)Enum.Parse(typeof(KitapTurler)));
          
        }
    }
}
