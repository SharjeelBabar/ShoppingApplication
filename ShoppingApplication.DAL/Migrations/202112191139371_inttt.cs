namespace ShoppingApplication.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inttt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseNo = c.String(),
                        StreetNo = c.String(),
                        Area = c.String(),
                        CityId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.CityId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        AccessToken = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        JoinedOn = c.DateTime(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Image = c.String(),
                        Description = c.String(),
                        Price = c.String(),
                        AddedOn = c.DateTime(nullable: false),
                        SellerId = c.Int(nullable: false),
                        ProductStatusId = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductStatus", t => t.ProductStatusId)
                .ForeignKey("dbo.Users", t => t.SellerId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .Index(t => t.SellerId)
                .Index(t => t.ProductStatusId)
                .Index(t => t.SubCategoryId);
            
            CreateTable(
                "dbo.ProductStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.BuyerId)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId)
                .Index(t => t.BuyerId)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "OrderStatusId", "dbo.OrderStatus");
            DropForeignKey("dbo.Orders", "BuyerId", "dbo.Users");
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Products", "ProductStatusId", "dbo.ProductStatus");
            DropForeignKey("dbo.AddressDetails", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.AddressDetails", "CityId", "dbo.Cities");
            DropIndex("dbo.Orders", new[] { "OrderStatusId" });
            DropIndex("dbo.Orders", new[] { "BuyerId" });
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.Products", new[] { "ProductStatusId" });
            DropIndex("dbo.Products", new[] { "SellerId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.AddressDetails", new[] { "UserId" });
            DropIndex("dbo.AddressDetails", new[] { "CityId" });
            DropTable("dbo.OrderStatus");
            DropTable("dbo.Orders");
            DropTable("dbo.SubCategories");
            DropTable("dbo.ProductStatus");
            DropTable("dbo.Products");
            DropTable("dbo.Images");
            DropTable("dbo.Categories");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Cities");
            DropTable("dbo.AddressDetails");
        }
    }
}
