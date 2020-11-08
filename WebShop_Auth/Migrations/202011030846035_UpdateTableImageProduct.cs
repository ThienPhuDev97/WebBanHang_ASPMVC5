namespace WebShop_Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableImageProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrlImage = c.String(),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ProductID", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductID" });
            DropTable("dbo.Images");
        }
    }
}
