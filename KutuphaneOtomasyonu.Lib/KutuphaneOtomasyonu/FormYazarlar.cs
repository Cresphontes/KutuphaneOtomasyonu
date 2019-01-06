
using KutuphaneOtomasyonu.BLL.Repository;
using KutuphaneOtomasyonu.Helpers;
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

            var dbYazar = new YazarRepo();
            var dbTur = new TurRepo();

            Yazar yazar = new Yazar();

         
           
            
            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value.Date;

           

            foreach (var item1 in CheckBoxes)
            {
                if (item1.Checked)
                {

                    Tur tur = new Tur();
                    
                    if (dbTur.GetAll().Count() == 0)
                    {
                        tur.TurAdi = item1.Text;
                        dbTur.Insert(tur);
                        dbTur.Update();
                      
                        
                    }
                    else
                    {

                        foreach (var item in dbTur.GetAll())
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
                            dbTur.Update();


                        }

                    }
  
                    dbTur.Update();

                    foreach (var item2 in dbTur.GetAll())
                    {
                        if(item2.TurAdi == item1.Text)
                        {
                            yazar.Turler.Add(item2);
                            item2.Yazarlar.Add(yazar);
                            dbYazar.Update();
                            dbTur.Update();
                        }
                       
                    }
                  
                }

                control = false;

            }

            
            YazarlariGetir();

        }


        private void YazarlariGetir()
        {
            YazarRepo db = new YazarRepo();
            var yazarlar = db.GetAll();
            

            i = 1;

            FormHelper.FormTemizle(this);
           

            foreach (var item in yazarlar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());
                lvItem.SubItems.Add(item.Ad);
                lvItem.SubItems.Add(item.Soyad);
                lvItem.SubItems.Add(item.DogumTarihi.Day + "/" + item.DogumTarihi.Month + "/" + item.DogumTarihi.Year);

                foreach (var item1 in item.Turler)
                {
                    lvItem.SubItems.Add(item1.TurAdi);
                }

                lvYazarlar.Items.Add(lvItem);
                i++;
            }
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            YazarlariGuncelle();
        }

        private void YazarlariGuncelle()
        {
            YazarRepo dbYazar = new YazarRepo();
            TurRepo dbTur = new TurRepo();
            var yazarlar = dbYazar.GetAll();

            Yazar secilenYazar = new Yazar();

            if (lvYazarlar.SelectedItems.Count == 0) return;

            ListViewItem lvItem = lvYazarlar.SelectedItems[0];

            foreach (var item in yazarlar)
            {
                if (item.Ad == lvItem.SubItems[1].Text && item.Soyad == lvItem.SubItems[2].Text)
                    secilenYazar = item;
                break;
            }

            secilenYazar.Ad = txtYazarAd.Text;
            secilenYazar.Soyad = txtYazarSoyad.Text;
            secilenYazar.DogumTarihi = dtYazarDogumTarihi.Value.Date;

            secilenYazar.Turler.Clear();

            foreach (var item in dbTur.GetAll())
            {
                foreach (var item1 in item.Yazarlar)
                {
                    if (item1.YazarId == secilenYazar.YazarId)
                        item.Yazarlar.Remove(item1);
                    break;
                }
            }

            dbYazar.Update();
            dbTur.Update();

            foreach (var item1 in CheckBoxes)
            {
                if (item1.Checked)
                {

                    Tur tur = new Tur();

                    if (dbTur.GetAll().Count() == 0)
                    {
                        tur.TurAdi = item1.Text;
                        dbTur.Insert(tur);
                        dbTur.Update();


                    }
                    else
                    {

                        foreach (var item in dbTur.GetAll())
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
                            dbTur.Update();


                        }

                    }

                    dbTur.Update();

                    foreach (var item2 in dbTur.GetAll())
                    {
                        if (item2.TurAdi == item1.Text)
                        {
                            secilenYazar.Turler.Add(item2);
                            item2.Yazarlar.Add(secilenYazar);
                            dbYazar.Update();
                            dbTur.Update();
                        }

                    }

                }

                control = false;

            }


            YazarlariGetir();

        }

        private void lvYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (lvYazarlar.SelectedItems.Count == 0) return;

            ListViewItem lvItem = lvYazarlar.SelectedItems[0];

            txtYazarAd.Text = lvItem.SubItems[1].Text;
            txtYazarSoyad.Text = lvItem.SubItems[2].Text;
            dtYazarDogumTarihi.Text = lvItem.SubItems[3].Text;


            foreach (var item in CheckBoxes)
            {
                if(item.Text == lvItem.SubItems[4].Text || item.Text == lvItem.SubItems[5].Text)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }

            }

        }
    }

        
}



