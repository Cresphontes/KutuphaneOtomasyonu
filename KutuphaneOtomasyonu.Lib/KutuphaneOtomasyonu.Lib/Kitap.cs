using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{
    public class Kitap
    {
        public string KitapAd { get; set; }
        public Yazar Yazar { get; set; }
        public KitapTurler Tur { get; set; }
        public string Yayin { get; set; }





    }
}
