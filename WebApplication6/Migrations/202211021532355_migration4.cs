namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyurulars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DuyuruBaslik = c.String(),
                        DuyuruBaslikResim = c.String(),
                        İcerik = c.String(),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Duyurulars", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Duyurulars", new[] { "KategoriId" });
            DropTable("dbo.Kategoris");
            DropTable("dbo.Duyurulars");
        }
    }
}
