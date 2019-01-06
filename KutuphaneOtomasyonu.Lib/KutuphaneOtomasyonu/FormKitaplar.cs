
using KutuphaneOtomasyonu.BLL.Repository;
using KutuphaneOtomasyonu.Helpers;

using KutuphaneOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

            KitapRepo db = new KitapRepo();
            YazarRepo dbYazar = new YazarRepo();


            Kitap kitap = new Kitap();
            Yazar yazar = new Yazar();

            var yazarlar = dbYazar.GetAll();
            var kitaplar = db.GetAll();


            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;

            foreach (var item in yazarlar)
            {
                if ((cmbYazar.SelectedItem as Yazar).YazarId == item.YazarId)
                {
                    kitap.Yazar = item;
                    item.Kitaplar.Add(kitap);
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

            db.Update();
            dbYazar.Update();

            KitaplariGetir();


        }



        private void FormKitaplar_Load(object sender, EventArgs e)
        {

            RadioButtons.Clear();

            KitaplariGetir();

            RadioButtons.Add(Bilim);
            RadioButtons.Add(Edebiyat);
            RadioButtons.Add(Tarih);
            RadioButtons.Add(Mizah);
            RadioButtons.Add(Psikoloji);
            RadioButtons.Add(Felsefe);
            RadioButtons.Add(Sanat);


        }

        private void KitaplariGetir()
        {
            KitapRepo db = new KitapRepo();

            i = 1;

            var kitaplar = db.GetAll();

            FormHelper.FormTemizle(this);

            foreach (var item in kitaplar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());


                lvItem.SubItems.Add(item.KitapAd);
                lvItem.SubItems.Add(item.Yazar.Ad + " " + item.Yazar.Soyad);
                lvItem.SubItems.Add(item.KitapTur);
                lvItem.SubItems.Add(item.Yayin);

                lvKitaplar.Items.Add(lvItem);

                i++;
            }
        }

        private void cmbYazar_DropDown(object sender, EventArgs e)
        {

            YazarRepo db = new YazarRepo();

            var yazarlar = db.GetAll();

            cmbYazar.Items.Clear();

            foreach (var item in RadioButtons)
            {
                if (item.Checked)
                {
                    foreach (var item1 in yazarlar)
                    {
                        foreach (var item2 in item1.Turler)
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


