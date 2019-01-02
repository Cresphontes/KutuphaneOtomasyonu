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

            Context db = new Context();

            Kitap kitap = new Kitap();
            Yazar yazar = new Yazar();

            var yazarlar = db.Yazarlar.ToList();
    
            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;

            foreach (var item in yazarlar)
            {
                if((cmbYazar.SelectedItem as Yazar).YazarId == item.YazarId)
                {
                    kitap.Yazar = item;
                    break;
                }
            }


            foreach (var item1 in RadioButtons)
            {
                if (item1.Checked)
                {
                    kitap.KitapTur = item1.Text;
                }
            }


            db.Kitaplar.Add(kitap);
            yazar.YazarKitaplar.Add(kitap);
            
            db.SaveChanges();

            lvKitaplar.Items.Clear();

         

            var Kitaplar = db.Kitaplar.ToList();

            foreach (var item in Kitaplar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());

                lvItem.SubItems.Add(item.KitapAd);
                lvItem.SubItems.Add(item.Yazar.Ad + " " + item.Yazar.Soyad);
                lvItem.SubItems.Add(item.KitapTur);
                lvItem.SubItems.Add(item.Yayin);

                lvKitaplar.Items.Add(lvItem);
                i++;
            }



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

            RadioButtons.Clear();

            i = 1;
            

            Context db = new Context();

            lvKitaplar.Items.Clear();

            var Kitaplar = db.Kitaplar.ToList();

            foreach (var item in Kitaplar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());


                lvItem.SubItems.Add(item.KitapAd);
                lvItem.SubItems.Add(item.Yazar.Ad + " " +item.Yazar.Soyad);
                lvItem.SubItems.Add(item.KitapTur);
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


        }


        private void cmbYazar_DropDown(object sender, EventArgs e)
        {

            Context db = new Context();
          

            cmbYazar.Items.Clear();

            foreach (var item in RadioButtons)
            {
                if (item.Checked)
                {
                    foreach (var item1 in db.Yazarlar.ToList())
                    {
                        foreach (var item2 in item1.YazarTurler)
                        {
                            if (item2.TurAdi == item.Text)
                            {
                                cmbYazar.Items.Add(item1);

                            }
                        }
                    }


                }
            }
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


 
            if (lvKitaplar.SelectedItems.Count == 0) return;
        
            ListViewItem lvItem = lvKitaplar.SelectedItems[0];

            txtKitapAd.Text = lvItem.SubItems[1].Text;
            txtYayin.Text = lvItem.SubItems[4].Text;
            cmbYazar.Text = lvItem.SubItems[2].Text;


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


