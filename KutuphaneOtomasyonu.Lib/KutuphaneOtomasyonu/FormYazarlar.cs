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
        public Context contextAc { get; set; }

        KitapTurler seciliCheckBox;
        int i = 1;


        private void FormYazarlar_Load(object sender, EventArgs e)
        {


            Yazar.CheckBoxes.Add(Bilim);
            Yazar.CheckBoxes.Add(Edebiyat);
            Yazar.CheckBoxes.Add(Tarih);
            Yazar.CheckBoxes.Add(Mizah);
            Yazar.CheckBoxes.Add(Psikoloji);
            Yazar.CheckBoxes.Add(Feksefe);
            Yazar.CheckBoxes.Add(Sanat);

        }

        private void btnYazarKaydet_Click_1(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar();



            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value;


            foreach (var item in Yazar.CheckBoxes)
            {
                if (item.Checked)
                {

                    seciliCheckBox = (KitapTurler)Enum.Parse(typeof(KitapTurler), item.Text);
                    yazar.YazarTurler.Add(seciliCheckBox);

                }
            }


            context.Yazarlar.Add(yazar);



            ListViewItem lvItem = new ListViewItem(i.ToString());

            lvItem.SubItems.Add(yazar.Ad);
            lvItem.SubItems.Add(yazar.Soyad);
            lvItem.SubItems.Add(dtYazarDogumTarihi.Text);

            string turlerToString = string.Join(",", yazar.YazarTurler.ToArray());

            lvItem.SubItems.Add(turlerToString);

            lvYazarlar.Items.Add(lvItem);
            i++;




        }

        private void kaydetYazar_Click(object sender, EventArgs e)
        {
            ExportImport kaydet = new ExportImport();
            kaydet.Export(context);
        }

        private void AcYazar_Click(object sender, EventArgs e)
        {
            ExportImport ac = new ExportImport();

            contextAc = ac.Import();

            lvYazarlar.Items.Clear();
            context.Yazarlar.Clear();
            context.Yazarlar.AddRange(contextAc.Yazarlar);

            i = 1;

            foreach (var item in contextAc.Yazarlar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());

                lvItem.SubItems.Add(item.Ad);
                lvItem.SubItems.Add(item.Soyad);
                lvItem.SubItems.Add(dtYazarDogumTarihi.Text);

                string turlerToString = string.Join(",", item.YazarTurler.ToArray());

                lvItem.SubItems.Add(turlerToString);

                lvYazarlar.Items.Add(lvItem);
                i++;
            }
        }

      
    }
}
