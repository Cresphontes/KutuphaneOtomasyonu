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
            context = Form1.context;

        }

        public static Context context { get; set; }
        int i = 1;
        

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {


            Kitap kitap = new Kitap();

            kitap.KitapAd = txtKitapAd.Text;
            kitap.Yayin = txtYayin.Text;
            kitap.Yazar = cmbYazar.SelectedItem as Yazar;


            foreach (var item1 in context.RadioButtons)
            {
                if (item1.Checked)
                {
                    kitap.Tur = (KitapTurler)Enum.Parse(typeof(KitapTurler), item1.Text);
                }
            }

           

            context.Kitaplar.Add(kitap);



            ListViewItem item = new ListViewItem(i.ToString());

            item.SubItems.Add(kitap.KitapAd);
            item.SubItems.Add(kitap.Yazar.ToString());
            item.SubItems.Add(kitap.Tur.ToString());
            item.SubItems.Add(kitap.Yayin);

            lvKitaplar.Items.Add(item);

            i++;


        }



        private void FormKitaplar_Load(object sender, EventArgs e)
        {

            context.RadioButtons.Add(Bilim);
            context.RadioButtons.Add(Edebiyat);
            context.RadioButtons.Add(Tarih);
            context.RadioButtons.Add(Mizah);
            context.RadioButtons.Add(Psikoloji);
            context.RadioButtons.Add(Felsefe);
            context.RadioButtons.Add(Sanat);

        }


        private void cmbYazar_DropDown(object sender, EventArgs e)
        {

            cmbYazar.Items.Clear();

            foreach (var item in context.RadioButtons)
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
    }
}
