namespace KutuphaneOtomasyonu.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "Uye_UyeId" });
            RenameColumn(table: "dbo.Kitaplar", name: "Uye_UyeId", newName: "UyeId");
            AlterColumn("dbo.Kitaplar", "UyeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kitaplar", "UyeId");
            AddForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler", "UyeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "UyeId" });
            AlterColumn("dbo.Kitaplar", "UyeId", c => c.Int());
            RenameColumn(table: "dbo.Kitaplar", name: "UyeId", newName: "Uye_UyeId");
            CreateIndex("dbo.Kitaplar", "Uye_UyeId");
            AddForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
        }
    }
}
