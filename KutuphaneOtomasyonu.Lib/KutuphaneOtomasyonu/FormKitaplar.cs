using KutuphaneOtomasyonu.Lib;
using KutuphaneOtomasyonu.Lib.Business;
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
using static System.Windows.Forms.ListView;

namespace KutuphaneOtomasyonu
{
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();

        }

        int i = 1;
        public static List<RadioButton> RadioButtons { get; set; } = new List<RadioButton>();


        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {

            i = 1;

            Kitap kitap = new Kitap();
            Tur tur = new Tur();

            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;
            kitap.Yazar = cmbYazar.SelectedItem as Yazar;


            //foreach (var item1 in RadioButtons)
            //{
            //    if (item1.Checked)
            //    {
            //        foreach (var item2 in tur.turler)
            //        {
            //            if (item1.Text == item2.ToString())
            //                kitap.Tur = (Tur)Enum.Parse(typeof(Tur), item1.Text);
            //        }
                   
            //    }
            //}


            Context db = new Context(); 
            db.Kitaplar.Add(kitap);
            db.SaveChanges();


            ListViewItem lvItem = new ListViewItem(i.ToString());

            var Kitaplar = db.Kitaplar.ToList();

            foreach (var item in Kitaplar)
            {
                lvItem.SubItems.Add(kitap.KitapAd);
                lvItem.SubItems.Add(kitap.Yazar.Ad);
                //lvItem.SubItems.Add(kitap.Tur.ToString());
                lvItem.SubItems.Add(kitap.Yayin);
            }
        
            lvKitaplar.Items.Add(lvItem);

            i++;

            txtKitapAd.Text = string.Empty;
            txtYayin.Text = string.Empty;
            cmbYazar.SelectedItem = null;

            Bilim.Checked = false;
            Edebiyat.Checked = false;
            Tarih.Checked = false;
            Mizah.Checked = false;
            Psikoloji.Checked = false;
            Felsefe.Checked = false;
            Sanat.Checked = false;



        }



        private void FormKitaplar_Load(object sender, EventArgs e)
        {

            i = 1;

            Context db = new Context();

            var Kitaplar = db.Kitaplar.ToList();

            foreach (var item in Kitaplar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(item.KitapAd);

                lvItem.SubItems.Add(item.Yazar.Ad);
                //lvItem.SubItems.Add(item.Tur.ToString());
                lvItem.SubItems.Add(item.Yayin);
                lvKitaplar.Items.Add(lvItem);

                i++;
            }

     

            RadioButtons.Add(Bilim);
            RadioButtons.Add(Edebiyat);
            RadioButtons.Add(Tarih);
            RadioButtons.Add(Mizah);
            RadioButtons.Add(Psikoloji);
            RadioButtons.Add(Felsefe);
            RadioButtons.Add(Sanat);

            Tur tur = new Tur();

            //tur.turler.Add(KitapTurler.Bilim);
            //tur.turler.Add(KitapTurler.Edebiyat);
            //tur.turler.Add(KitapTurler.Tarih);
            //tur.turler.Add(KitapTurler.Mizah);
            //tur.turler.Add(KitapTurler.Psikoloji);
            //tur.turler.Add(KitapTurler.Felsefe);
            //tur.turler.Add(KitapTurler.Sanat);

        }


        private void cmbYazar_DropDown(object sender, EventArgs e)
        {

            Context db = new Context();
          

            cmbYazar.Items.Clear();

            //foreach (var item in RadioButtons)
            //{
            //    if (item.Checked)
            //    {
            //        foreach (var item1 in db.Yazarlar)
            //        {
            //            foreach (var item2 in item1.YazarTurler)
            //            {
            //                if (item2.ToString() == item.Text)
            //                {
            //                    cmbYazar.Items.Add(item1);

            //                }
            //            }
            //        }


            //    }
            //}
        }

        //private void kaydetKitap_Click(object sender, EventArgs e)
        //{
        //    ExportImport kaydet = new ExportImport();
        //    kaydet.Export(context);
        //}

        //private void acKitap_Click(object sender, EventArgs e)
        //{
        //    ExportImport ac = new ExportImport();

        //    contextAc = ac.Import();

        //    lvKitaplar.Items.Clear();
            
        //    context.Kitaplar.AddRange(contextAc.Kitaplar);

        //    i = 1;

        //    foreach (var item in contextAc.Kitaplar)
        //    {
        //        ListViewItem lvItem = new ListViewItem(i.ToString());

        //        lvItem.SubItems.Add(item.KitapAd);
        //        lvItem.SubItems.Add(item.Yazar.ToString());
        //        lvItem.SubItems.Add(item.Tur.ToString());
        //        lvItem.SubItems.Add(item.Yayin);

        //        lvKitaplar.Items.Add(lvItem);

        //        i++;
        //    }
        //}


        private void lvKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvKitaplar.SelectedItems == null) return;
        
            var lvItem = lvKitaplar.SelectedItems[0];

            txtKitapAd.Text = lvItem.SubItems[1].Text;
            txtYayin.Text = lvItem.SubItems[4].Text;
            cmbYazar.SelectedItem = lvItem.SubItems[2].Text;


            switch (lvItem.SubItems[3].Text)
            {
                case "Bilim":
                    Bilim.Checked = true;
                    break;
                case "Edebiyat":
                    Edebiyat.Checked = true;
                    break;
                case "Tarih":
                    Tarih.Checked = true;
                    break;
                case "Mizah":
                    Mizah.Checked = true;
                    break;
                case "Psikoloji":
                    Psikoloji.Checked = true;
                    break;
                case "Felsefe":
                    Felsefe.Checked = true;
                    break;
                case "Sanat":
                    Sanat.Checked = true;
                    break;
                default:
                    break;
            }


        }


    }
}


