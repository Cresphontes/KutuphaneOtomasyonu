namespace KutuphaneOtomasyonu.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kayitlar",
                c => new
                    {
                        KayitId = c.Int(nullable: false, identity: true),
                        Kitap_KitapId = c.Int(),
                        Uye_UyeId = c.Int(),
                    })
                .PrimaryKey(t => t.KayitId)
                .ForeignKey("dbo.Kitaplar", t => t.Kitap_KitapId)
                .ForeignKey("dbo.Uyeler", t => t.Uye_UyeId)
                .Index(t => t.Kitap_KitapId)
                .Index(t => t.Uye_UyeId);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false),
                        KitapAd = c.String(),
                        Tur = c.Int(nullable: false),
                        Yayin = c.String(),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.KitapId)
                .Index(t => t.KitapId)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        TCKN = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        KitapId = c.Int(nullable: false),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kayitlar", "Uye_UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kitaplar", "KitapId", "dbo.Uyeler");
            DropForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", new[] { "KitapId" });
            DropIndex("dbo.Kayitlar", new[] { "Uye_UyeId" });
            DropIndex("dbo.Kayitlar", new[] { "Kitap_KitapId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kayitlar");
        }
    }
}
