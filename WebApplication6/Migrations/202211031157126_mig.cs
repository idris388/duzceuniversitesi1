namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FakülteGenelBilgi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GenelBilgi = c.String(),
                        Yonetim = c.String(),
                        Personel = c.String(),
                        Ogrenci = c.String(),
                        Fakültemiz = c.String(),
                        FakülteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fakülte", t => t.FakülteID, cascadeDelete: true)
                .Index(t => t.FakülteID);
            
            CreateTable(
                "dbo.Fakülte",
                c => new
                    {
                        FakülteID = c.Int(nullable: false, identity: true),
                        FakülteAdi = c.String(),
                    })
                .PrimaryKey(t => t.FakülteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FakülteGenelBilgi", "FakülteID", "dbo.Fakülte");
            DropIndex("dbo.FakülteGenelBilgi", new[] { "FakülteID" });
            DropTable("dbo.Fakülte");
            DropTable("dbo.FakülteGenelBilgi");
        }
    }
}
