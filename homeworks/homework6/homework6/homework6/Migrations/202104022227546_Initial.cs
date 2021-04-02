namespace homework6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        TypeOfCar = c.String(nullable: false),
                        Engine = c.Double(nullable: false),
                        HorsePower = c.Int(nullable: false),
                        HasElectricWindows = c.Boolean(nullable: false),
                        HasNavigation = c.Boolean(nullable: false),
                        Customer_Id = c.Int(),
                        Inventory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers1", t => t.Customer_Id)
                .ForeignKey("dbo.Inventories", t => t.Inventory_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.Inventory_Id);
            
            CreateTable(
                "dbo.Customers1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        InterestedInCar_Id = c.Int(),
                        Customers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.InterestedInCar_Id)
                .ForeignKey("dbo.Customers", t => t.Customers_Id)
                .Index(t => t.InterestedInCar_Id)
                .Index(t => t.Customers_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Inventory_Id", "dbo.Inventories");
            DropForeignKey("dbo.Customers1", "Customers_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers1", "InterestedInCar_Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "Customer_Id", "dbo.Customers1");
            DropIndex("dbo.Customers1", new[] { "Customers_Id" });
            DropIndex("dbo.Customers1", new[] { "InterestedInCar_Id" });
            DropIndex("dbo.Cars", new[] { "Inventory_Id" });
            DropIndex("dbo.Cars", new[] { "Customer_Id" });
            DropTable("dbo.Inventories");
            DropTable("dbo.Customers");
            DropTable("dbo.Customers1");
            DropTable("dbo.Cars");
        }
    }
}
