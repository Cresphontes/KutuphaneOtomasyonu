using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{
    public interface IAtamaKitapYazar<T1,T2>where T1:Yazar where T2:Kitap
    {

        void AtamaYapKitapYazar(T1 nereye,T2 neyi);
        
    }
}
