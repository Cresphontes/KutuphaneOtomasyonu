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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormKitaplar frmKitaplar;
        FormUyeler frmUyeler;
        FormKiralama frmKiralama;

        public Context context { get; set; }

        private void BtnKitapKayit_Click(object sender, EventArgs e)
        {
            frmKitaplar = new FormKitaplar();
            frmKitaplar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new MockData().context;
        }

        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            frmUyeler = new FormUyeler();
            frmUyeler.Show();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            frmKiralama = new FormKiralama();
            frmKiralama.Show();
        }
    }
}
