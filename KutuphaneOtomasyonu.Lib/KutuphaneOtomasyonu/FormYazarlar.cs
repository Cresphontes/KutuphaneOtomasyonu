
using KutuphaneOtomasyonu.BLL.Repository;
using KutuphaneOtomasyonu.Helpers;
using KutuphaneOtomasyonu.Models;
using KutuphaneOtomasyonu.Models.Entities;
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


        public static List<CheckBox> CheckBoxes { get; set; } = new List<CheckBox>();
        int i = 1;
        bool control = false;


        private void FormYazarlar_Load(object sender, EventArgs e)
        {

            YazarlariGetir();

            CheckBoxes.Clear();

            CheckBoxes.Add(Bilim);
            CheckBoxes.Add(Edebiyat);
            CheckBoxes.Add(Tarih);
            CheckBoxes.Add(Mizah);
            CheckBoxes.Add(Psikoloji);
            CheckBoxes.Add(Felsefe);
            CheckBoxes.Add(Sanat);

        }


        private void btnYazarKaydet_Click_1(object sender, EventArgs e)
        {

            i = 1;

            var dbYazar = new YazarRepo();
            var dbTur = new TurRepo();
            var db_Yazar_Tur = new Yazar_Tur_Repo();

            var yazarlar = dbYazar.GetAll();
            var turler = dbTur.GetAll();
            var yazar_turler = db_Yazar_Tur.GetAll();

            Yazar yazar = new Yazar();
            Yazar_Tur yazar_tur = new Yazar_Tur();
            
            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value.Date;


            foreach (var item1 in CheckBoxes)
            {
                if (item1.Checked)
                {

                    Tur tur = new Tur();
                    
                    if (turler.Count() == 0)
                    {
                        tur.TurAdi = item1.Text;
                        dbTur.Insert(tur);
                      
                        
                    }
                    else
                    {

                        foreach (var item in turler)
                        {

                            if (item.TurAdi == item1.Text)
                            {
                                control = true;
                                break;
                            }

                        }

                         if (control == false)
                        {
                            tur.TurAdi = item1.Text;
                            dbTur.Insert(tur);


                        }

                    }
  
                    dbTur.Update();

                    foreach (var item2 in turler)
                    {
                        if(item2.TurAdi == item1.Text)
                        {
                            yazar_tur.YazarId = item2.TurId;

                        }
                       
                    }
                  
                }

                control = false;

            }

            dbYazar.Insert(yazar);

            YazarlariGetir();

        }


        private void YazarlariGetir()
        {
            YazarRepo db = new YazarRepo();

            i = 1;

            var yazarlar = db.GetAll();

            FormHelper.FormTemizle(this);

            foreach (var item in yazarlar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(item.Ad);
                lvItem.SubItems.Add(item.Soyad);
                lvItem.SubItems.Add(item.DogumTarihi.Day + "/" + item.DogumTarihi.Month + "/" + item.DogumTarihi.Year);

                foreach (var item1 in item.YazarTurler)
                {
                    lvItem.SubItems.Add(item1.TurAdi);
                }

                lvYazarlar.Items.Add(lvItem);
                i++;
            }
        }

    }

}
