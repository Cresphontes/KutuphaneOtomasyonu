using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{
    public class Yazar:Insan
    {
        public List<Kitap> YazarKitaplar { get; set; } = new List<Kitap>();
    }
}
