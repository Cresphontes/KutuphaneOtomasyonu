using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{
    public class Uye:Insan
    {
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public List<Kitap> UyeKitaplar { get; set; } = new List<Kitap>();

        public override string ToString()
        {
            return $"{this.Ad + " " + this.Soyad }";
        }

    }
}
