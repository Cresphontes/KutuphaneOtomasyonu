using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{
    public interface IAtamaKitapUye<T1,T2>where T1:Uye where T2:Kitap
    {

        void AtamaYapKitapUye(T1 nereye, T2 neyi);
    }
}
