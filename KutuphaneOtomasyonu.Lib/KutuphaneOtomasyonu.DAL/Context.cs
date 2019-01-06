
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
    public class Context : DbContext
    {
        public Context() : base("name=MyCon")
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Kayit> Kayitlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yazar>()
                .HasMany<Tur>(s => s.Turler)
                .WithMany(c => c.Yazarlar)
                .Map(cs =>
                {
                    cs.MapLeftKey("YazarId");
                    cs.MapRightKey("TurId");
                    cs.ToTable("Yazar_Turler");
                });

            //modelBuilder.Entity<Kitap>()
            //    .HasRequired<Yazar>(s => s.Yazar)
            //    .WithMany(g => g.Kitaplar)
            //    .HasForeignKey<int>(s => s.YazarId);



        }



    }
}
