namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        adminAd = c.String(),
                        adminMail = c.String(),
                        adminSifre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.İhtisaslaşma",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        İcerik = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Üniversitemiz",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        İcerik = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Üniversitemiz");
            DropTable("dbo.İhtisaslaşma");
            DropTable("dbo.Admins");
        }
    }
}
