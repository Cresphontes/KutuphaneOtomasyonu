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

namespace KutuphaneOtomasyonu
{
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
            context = Form1.context;

        }

        public static Context context { get; set; }
        public Context contextAc { get; set; }
        int i = 1;


        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {


            Kitap kitap = new Kitap();

            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;
            kitap.Yazar = cmbYazar.SelectedItem as Yazar;


            foreach (var item1 in Kitap.RadioButtons)
            {
                if (item1.Checked)
                {
                    kitap.Tur = (KitapTurler)Enum.Parse(typeof(KitapTurler), item1.Text);
                }
            }



            context.Kitaplar.Add(kitap);



            ListViewItem lvItem = new ListViewItem(i.ToString());

            lvItem.SubItems.Add(kitap.KitapAd);
            lvItem.SubItems.Add(kitap.Yazar.Ad);
            lvItem.SubItems.Add(kitap.Tur.ToString());
            lvItem.SubItems.Add(kitap.Yayin);

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

            Kitap.RadioButtons.Add(Bilim);
            Kitap.RadioButtons.Add(Edebiyat);
            Kitap.RadioButtons.Add(Tarih);
            Kitap.RadioButtons.Add(Mizah);
            Kitap.RadioButtons.Add(Psikoloji);
            Kitap.RadioButtons.Add(Felsefe);
            Kitap.RadioButtons.Add(Sanat);

        }


        private void cmbYazar_DropDown(object sender, EventArgs e)
        {

            cmbYazar.Items.Clear();

            foreach (var item in Kitap.RadioButtons)
            {
                if (item.Checked)
                {
                    foreach (var item1 in context.Yazarlar)
                    {
                        foreach (var item2 in item1.YazarTurler)
                        {
                            if (item2.ToString() == item.Text)
                            {
                                cmbYazar.Items.Add(item1);

                            }
                        }
                    }


                }
            }
        }

        private void kaydetKitap_Click(object sender, EventArgs e)
        {
            ExportImport kaydet = new ExportImport();
            kaydet.Export(context);
        }

        private void acKitap_Click(object sender, EventArgs e)
        {
            ExportImport ac = new ExportImport();

            contextAc = ac.Import();

            lvKitaplar.Items.Clear();
            context.Kitaplar.Clear();
            context.Kitaplar.AddRange(contextAc.Kitaplar);
            
            i = 1;

            foreach (var item in contextAc.Kitaplar)
            {
                ListViewItem lvItem = new ListViewItem(i.ToString());

                lvItem.SubItems.Add(item.KitapAd);
                lvItem.SubItems.Add(item.Yazar.ToString());
                lvItem.SubItems.Add(item.Tur.ToString());
                lvItem.SubItems.Add(item.Yayin);

                lvKitaplar.Items.Add(lvItem);

                i++;
            }
        }

        private void lvKitaplar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            
            Kitap seciliKitap = new Kitap();

            foreach (var item in lvKitaplar.CheckedItems)
            {
                seciliKitap = item as Kitap;

                txtKitapAd.Text = seciliKitap.KitapAd.ToString();
                txtYayin.Text = seciliKitap.Yayin.ToString();
                cmbYazar.SelectedItem = seciliKitap.Yazar;


                switch (seciliKitap.Tur)
                {
                    case KitapTurler.Bilim:
                        Bilim.Checked = true;
                        break;
                    case KitapTurler.Edebiyat:
                        Edebiyat.Checked = true;
                        break;
                    case KitapTurler.Tarih:
                        Tarih.Checked = true;
                        break;
                    case KitapTurler.Mizah:
                        Mizah.Checked = true;
                        break;
                    case KitapTurler.Psikoloji:
                        Psikoloji.Checked = true;
                        break;
                    case KitapTurler.Felsefe:
                        Felsefe.Checked = true;
                        break;
                    case KitapTurler.Sanat:
                        Sanat.Checked = true;
                        break;
                    default:
                        break;
                }

               
            }

            
           
        }

       
        

   
    }
}
