namespace eStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reseed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "RetailPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "WholesalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "InventoryCount", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Products", "InventoryCount");
            DropColumn("dbo.Products", "WholesalePrice");
            DropColumn("dbo.Products", "RetailPrice");
        }
    }
}
