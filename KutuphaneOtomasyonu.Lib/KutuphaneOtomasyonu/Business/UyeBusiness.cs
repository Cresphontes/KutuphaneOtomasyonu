using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib.Business
{
    public class UyeBusiness : IAtamaKitapUye<Uye, Kitap>
    {
        public void AtamaYapKitapUye(Uye nereye, Kitap neyi)
        {
            nereye.UyeKitaplar.Add(neyi);
        }
    }
}
