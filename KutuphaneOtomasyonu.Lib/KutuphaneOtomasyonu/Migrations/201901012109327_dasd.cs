namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dasd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kayitlar",
                c => new
                    {
                        KayitId = c.Int(nullable: false, identity: true),
                        UyeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KayitId)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId);
            
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
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAd = c.String(),
                        Yayin = c.String(),
                        KitapTur = c.String(),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Turler",
                c => new
                    {
                        TurId = c.Int(nullable: false, identity: true),
                        TurAdi = c.String(),
                    })
                .PrimaryKey(t => t.TurId);
            
            CreateTable(
                "dbo.TurYazars",
                c => new
                    {
                        Tur_TurId = c.Int(nullable: false),
                        Yazar_YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tur_TurId, t.Yazar_YazarId })
                .ForeignKey("dbo.Turler", t => t.Tur_TurId, cascadeDelete: true)
                .ForeignKey("dbo.Yazarlar", t => t.Yazar_YazarId, cascadeDelete: true)
                .Index(t => t.Tur_TurId)
                .Index(t => t.Yazar_YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TurYazars", "Yazar_YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.TurYazars", "Tur_TurId", "dbo.Turler");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kayitlar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.TurYazars", new[] { "Yazar_YazarId" });
            DropIndex("dbo.TurYazars", new[] { "Tur_TurId" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kayitlar", new[] { "UyeId" });
            DropTable("dbo.TurYazars");
            DropTable("dbo.Turler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Uyeler");
            DropTable("dbo.Kayitlar");
        }
    }
}
