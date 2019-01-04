
using KutuphaneOtomasyonu.Models;
using KutuphaneOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneOtomasyonu.DAL
{
    public class Context:DbContext
    {
        public Context():base("name=MyCon")
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; } 
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Yazar_Tur> Yazar_Turler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        
        public DbSet<Kayit> Kayitlar { get; set; }
       

        
        
    }
}
