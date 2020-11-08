namespace WebShop_Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderProducts", new[] { "Order_Id" });
            DropIndex("dbo.OrderProducts", new[] { "Product_Id" });
            AddColumn("dbo.OrderProducts", "Order_Id1", c => c.Int());
            AddColumn("dbo.OrderProducts", "Product_Id1", c => c.Int());
            AlterColumn("dbo.OrderProducts", "Order_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderProducts", "Product_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.OrderProducts", "Order_Id1");
            CreateIndex("dbo.OrderProducts", "Product_Id1");
            AddForeignKey("dbo.OrderProducts", "Product_Id1", "dbo.Products", "Id");
            AddForeignKey("dbo.OrderProducts", "Order_Id1", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", "Order_Id1", "dbo.Orders");
            DropForeignKey("dbo.OrderProducts", "Product_Id1", "dbo.Products");
            DropIndex("dbo.OrderProducts", new[] { "Product_Id1" });
            DropIndex("dbo.OrderProducts", new[] { "Order_Id1" });
            AlterColumn("dbo.OrderProducts", "Product_Id", c => c.Int());
            AlterColumn("dbo.OrderProducts", "Order_Id", c => c.Int());
            DropColumn("dbo.OrderProducts", "Product_Id1");
            DropColumn("dbo.OrderProducts", "Order_Id1");
            CreateIndex("dbo.OrderProducts", "Product_Id");
            CreateIndex("dbo.OrderProducts", "Order_Id");
            AddForeignKey("dbo.OrderProducts", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderProducts", "Product_Id", "dbo.Products", "Id");
        }
    }
}
