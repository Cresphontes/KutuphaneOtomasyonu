using KutuphaneOtomasyonu.Lib;
using KutuphaneOtomasyonu.Lib.Business;
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
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
        }

        List<RadioButton> radioButtons { get; set; } = new List<RadioButton>();
        List<KitapTurler> turler = new List<KitapTurler>();
        public Context context { get; set; }


        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {


            Kitap kitap = new Kitap();


            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;
            kitap.Yazar = cmbYazar.SelectedItem as Yazar;


            context.Kitaplar.Add(kitap);


        }



        private void FormKitaplar_Load(object sender, EventArgs e)
        {



            radioButtons = new List<RadioButton>() { radioBtn1, radioBtn2, radioBtn3, radioBtn4, radioBtn5, radioBtn6, radioBtn7 };
            turler.AddRange((KitapTurler)Enum.Parse(typeof(KitapTurler)));

            foreach (var item in context.Yazarlar)
            {
                item.YazarTurler.Add();
            }

        }

        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn1.Checked)
            {
                foreach (var item in context.Yazarlar)
                {
                    if(item.)
                }
            }
        }
    }
}
