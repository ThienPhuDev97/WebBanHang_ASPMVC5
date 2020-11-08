namespace WebShop_Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImageProduct2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageProduct", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImageProduct");
        }
    }
}
