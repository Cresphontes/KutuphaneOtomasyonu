namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s3 : DbMigration
    {
        public override void Up()
        {
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
            AddColumn("dbo.Kayitlar", "RafId", c => c.Int(nullable: false));
            DropForeignKey("dbo.TurYazars", "Yazar_YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.TurYazars", "Tur_TurId", "dbo.Turler");
            DropIndex("dbo.TurYazars", new[] { "Yazar_YazarId" });
            DropIndex("dbo.TurYazars", new[] { "Tur_TurId" });
            DropTable("dbo.TurYazars");
            DropTable("dbo.Turler");
        }
    }
}
