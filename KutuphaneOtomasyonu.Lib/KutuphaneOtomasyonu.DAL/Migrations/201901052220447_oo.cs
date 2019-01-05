namespace KutuphaneOtomasyonu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oo : DbMigration
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
                "dbo.Yazar_Turler",
                c => new
                    {
                        YazarId = c.Int(nullable: false),
                        TurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.YazarId, t.TurId })
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .ForeignKey("dbo.Turler", t => t.TurId, cascadeDelete: true)
                .Index(t => t.YazarId)
                .Index(t => t.TurId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Yazar_Turler", "TurId", "dbo.Turler");
            DropForeignKey("dbo.Yazar_Turler", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kayitlar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.Yazar_Turler", new[] { "TurId" });
            DropIndex("dbo.Yazar_Turler", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kayitlar", new[] { "UyeId" });
            DropTable("dbo.Yazar_Turler");
            DropTable("dbo.Turler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Uyeler");
            DropTable("dbo.Kayitlar");
        }
    }
}
