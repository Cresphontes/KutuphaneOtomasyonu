namespace KutuphaneOtomasyonu.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "KitapId", "dbo.Uyeler");
            DropForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kitaplar", new[] { "KitapId" });
            DropPrimaryKey("dbo.Kitaplar");
            AddColumn("dbo.Kitaplar", "Uye_UyeId", c => c.Int());
            AlterColumn("dbo.Kitaplar", "KitapId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Kitaplar", "KitapId");
            CreateIndex("dbo.Kitaplar", "Uye_UyeId");
            AddForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
            AddForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar", "KitapId");
            DropColumn("dbo.Yazarlar", "KitapId");
            DropColumn("dbo.Uyeler", "KitapId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uyeler", "KitapId", c => c.Int(nullable: false));
            AddColumn("dbo.Yazarlar", "KitapId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "Uye_UyeId" });
            DropPrimaryKey("dbo.Kitaplar");
            AlterColumn("dbo.Kitaplar", "KitapId", c => c.Int(nullable: false));
            DropColumn("dbo.Kitaplar", "Uye_UyeId");
            AddPrimaryKey("dbo.Kitaplar", "KitapId");
            CreateIndex("dbo.Kitaplar", "KitapId");
            AddForeignKey("dbo.Kayitlar", "Kitap_KitapId", "dbo.Kitaplar", "KitapId");
            AddForeignKey("dbo.Kitaplar", "KitapId", "dbo.Uyeler", "UyeId");
        }
    }
}
