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
        }


        public static List<CheckBox> CheckBoxes { get; set; } = new List<CheckBox>();
        

        int i = 1;


        private void FormYazarlar_Load(object sender, EventArgs e)
        {

      
            

            i = 1;

            Context db = new Context();

            var yazarlar = db.Yazarlar.ToList();
            var turler = db.Turler.ToList();

            lvYazarlar.Items.Clear();

            foreach (var item in yazarlar)
            {
                
                    ListViewItem lvItem = new ListViewItem(i.ToString());
                    lvItem.SubItems.Add(item.Ad);
                    lvItem.SubItems.Add(item.Soyad);
                    lvItem.SubItems.Add(item.DogumTarihi.ToString());
                foreach (var item1 in item.YazarTurler)
                {
                    lvItem.SubItems.Add(item1.TurAdi);
                }
                lvYazarlar.Items.Add(lvItem);
                    i++;
               
                

            
            }

            

            CheckBoxes.Add(Bilim);
            CheckBoxes.Add(Edebiyat);
            CheckBoxes.Add(Tarih);
            CheckBoxes.Add(Mizah);
            CheckBoxes.Add(Psikoloji);
            CheckBoxes.Add(Feksefe);
            CheckBoxes.Add(Sanat);

        }

        private void btnYazarKaydet_Click_1(object sender, EventArgs e)
        {

            i = 1;

            Context db = new Context();

            Yazar yazar = new Yazar();
            

            
            
            yazar.Ad = txtYazarAd.Text;
            yazar.Soyad = txtYazarSoyad.Text;
            yazar.DogumTarihi = dtYazarDogumTarihi.Value;
         


            

            foreach (var item1 in CheckBoxes)
            {
                if (item1.Checked)
                {
                    Tur tur = new Tur();
                    tur.TurAdi = item1.Text;
                    yazar.YazarTurler.Add(tur);
                    tur.TurYazarlar.Add(yazar);

                    if (db.Turler.Count() == 0)
                    {
                        db.Turler.Add(tur);
                    }
                    else
                    {

                        foreach (var item in db.Turler)
                        {
                            if (item.ToString() != tur.ToString())
                            {
                                db.Turler.Add(tur);
                            }
                        }

                    }
                }      

            }

            db.Yazarlar.Add(yazar);
            db.SaveChanges();


            lvYazarlar.Items.Clear();


            ListViewItem lvItem = new ListViewItem(i.ToString());



            var yazarlar = db.Yazarlar.ToList();

            foreach (var item in yazarlar)
            {
                lvItem.SubItems.Add(item.Ad);
                lvItem.SubItems.Add(item.Soyad);
                lvItem.SubItems.Add(item.DogumTarihi.ToString());
                foreach (var item1 in item.YazarTurler)
                {
                    lvItem.SubItems.Add(item1.TurAdi);
                }


            }


            lvYazarlar.Items.Add(lvItem);
            i++;



        }

        //private void kaydetYazar_Click(object sender, EventArgs e)
        //{
        //    ExportImport kaydet = new ExportImport();
        //    kaydet.Export(context);
        //}

        //private void AcYazar_Click(object sender, EventArgs e)
        //{
        //    ExportImport ac = new ExportImport();

        //    contextAc = ac.Import();

        //    lvYazarlar.Items.Clear();
        //    context.Kitaplar.Clear();
        //    context.Yazarlar.AddRange(contextAc.Yazarlar);

        //    i = 1;

        //    foreach (var item in contextAc.Yazarlar)
        //    {
        //        ListViewItem lvItem = new ListViewItem(i.ToString());

        //        lvItem.SubItems.Add(item.Ad);
        //        lvItem.SubItems.Add(item.Soyad);
        //        lvItem.SubItems.Add(dtYazarDogumTarihi.Text);

        //        string turlerToString = string.Join(",", item.YazarTurler.ToArray());

        //        lvItem.SubItems.Add(turlerToString);

        //        lvYazarlar.Items.Add(lvItem);
        //        i++;
        //    }
        //}

      
    }
}
