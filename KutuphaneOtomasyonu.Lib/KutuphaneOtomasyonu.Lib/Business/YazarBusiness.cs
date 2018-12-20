using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib.Business
{
    public class YazarBusiness : IAtamaKitapYazar<Yazar, Kitap>
    {
        public void AtamaYapKitapYazar(Yazar nereye, Kitap neyi)
        {
            nereye.YazarKitaplar.Add(neyi);
        }
    }
}
