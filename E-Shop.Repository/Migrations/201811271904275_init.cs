namespace E_Shop.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Length = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specification",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Storage = c.Int(nullable: false),
                        OSType = c.Int(nullable: false),
                        Camera = c.Byte(nullable: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Specification", "Product_Id", "dbo.Product");
            DropIndex("dbo.Specification", new[] { "Product_Id" });
            DropTable("dbo.Specification");
            DropTable("dbo.Product");
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Image");
        }
    }
}
