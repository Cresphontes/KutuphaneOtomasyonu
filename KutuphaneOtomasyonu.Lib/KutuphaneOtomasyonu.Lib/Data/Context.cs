using KutuphaneOtomasyonu.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib.Data
{
    public class Context
    {
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();
        public List<Yazar> Yazarlar { get; set; } = new List<Yazar>();
        public List<Uye> Uyeler { get; set; } = new List<Uye>();
        public List<Kayit> Kayitlar { get; set; } = new List<Kayit>();
       

        
        
    }
}
