using KutuphaneOtomasyonu.Lib;
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
    public partial class FormYazarlar : Form
    {
        public FormYazarlar()
        {
            InitializeComponent();
            context = Form1.context;
        }
        
        public static Context context { get; set; }
        KitapTurler seciliCheckBox;
        int i = 1;
        

        private void FormYazarlar_Load(object sender, EventArgs e)
        {
             

            context.CheckBoxes.Add(Bilim);
            context.CheckBoxes.Add(Edebiyat);
            context.CheckBoxes.Add(Tarih);
            context.CheckBoxes.Add(Mizah);
            context.CheckBoxes.Add(Psikoloji);
            context.CheckBoxes.Add(Feksefe);
            context.CheckBoxes.Add(Sanat);

        }

        private void btnYazarKaydet_Click_1(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();
           


            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value;


            foreach (var item in context.CheckBoxes)
            {
                if (item.Checked)
                {

                    seciliCheckBox = (KitapTurler)Enum.Parse(typeof(KitapTurler),item.Text);
                    yazar.YazarTurler.Add(seciliCheckBox);
                    
                }
            }


            context.Yazarlar.Add(yazar);


            ListViewItem lvItem = new ListViewItem(i.ToString());

            lvItem.SubItems.Add(yazar.Ad);
            lvItem.SubItems.Add(yazar.Soyad);
            lvItem.SubItems.Add(dtYazarDogumTarihi.Text);

            string turlerToString = string.Join(",",yazar.YazarTurler.ToArray());

            lvItem.SubItems.Add(turlerToString);

            lvYazarlar.Items.Add(lvItem);
            i++;

            

             
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportImport.
        }
    }
}
