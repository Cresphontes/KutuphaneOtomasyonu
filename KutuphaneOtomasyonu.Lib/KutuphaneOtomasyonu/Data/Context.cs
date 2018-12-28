using KutuphaneOtomasyonu.Lib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib.Data
{
    public class Context:DbContext
    {
        public Context():base("name=MyCon")
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; } 
        public DbSet<Yazar> Yazarlar { get; set; } 
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Kayit> Kayitlar { get; set; }
       

        
        
    }
}
