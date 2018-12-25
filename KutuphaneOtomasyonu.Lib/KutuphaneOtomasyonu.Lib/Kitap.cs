using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib
{
    public class Kitap
    {
        public string KitapAd { get; set; }
        public Yazar Yazar { get; set; }
        public KitapTurler Tur { get; set; }
        public string Yayin { get; set; }
        public static List<RadioButton> RadioButtons { get; set; } = new List<RadioButton>();





    }
}
