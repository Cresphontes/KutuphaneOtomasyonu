namespace KutuphaneOtomasyonu.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazarlar", "KitapTurler", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yazarlar", "KitapTurler");
        }
    }
}
