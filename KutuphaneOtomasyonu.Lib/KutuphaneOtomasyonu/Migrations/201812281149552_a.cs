namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
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
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAd = c.String(),
                        Yayin = c.String(),
                        YazarId = c.Int(nullable: false),
                        TurId = c.Int(nullable: false),
                        Tur_TurId = c.Int(),
                        Uye_UyeId = c.Int(),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Türler", t => t.Tur_TurId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .ForeignKey("dbo.Türler", t => t.TurId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.Uye_UyeId)
                .Index(t => t.YazarId)
                .Index(t => t.TurId)
                .Index(t => t.Tur_TurId)
                .Index(t => t.Uye_UyeId);
            
            CreateTable(
                "dbo.Türler",
                c => new
                    {
                        TurId = c.Int(nullable: false, identity: true),
                        TurAd = c.String(),
                        YazarId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        Yazar_YazarId = c.Int(),
                    })
                .PrimaryKey(t => t.TurId)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Yazarlar", t => t.Yazar_YazarId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId)
                .Index(t => t.KitapId)
                .Index(t => t.Yazar_YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Tur_TurId = c.Int(),
                    })
                .PrimaryKey(t => t.YazarId)
                .ForeignKey("dbo.Türler", t => t.Tur_TurId)
                .Index(t => t.Tur_TurId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        TCKN = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kayitlar", "Uye_UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "TurId", "dbo.Türler");
            DropForeignKey("dbo.Türler", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Yazarlar", "Tur_TurId", "dbo.Türler");
            DropForeignKey("dbo.Türler", "Yazar_YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kitaplar", "Tur_TurId", "dbo.Türler");
            DropForeignKey("dbo.Türler", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Yazarlar", new[] { "Tur_TurId" });
            DropIndex("dbo.Türler", new[] { "Yazar_YazarId" });
            DropIndex("dbo.Türler", new[] { "KitapId" });
            DropIndex("dbo.Türler", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", new[] { "Uye_UyeId" });
            DropIndex("dbo.Kitaplar", new[] { "Tur_TurId" });
            DropIndex("dbo.Kitaplar", new[] { "TurId" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kayitlar", new[] { "Uye_UyeId" });
            DropIndex("dbo.Kayitlar", new[] { "Kitap_KitapId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Türler");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kayitlar");
        }
    }
}
