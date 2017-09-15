namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchaseInfoUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseInformations", "Vendor", c => c.String());
            AddColumn("dbo.PurchaseInformations", "TimeOfPurchase", c => c.DateTime(nullable: false));
            AddColumn("dbo.PurchaseInformations", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseInformations", "Location");
            DropColumn("dbo.PurchaseInformations", "TimeOfPurchase");
            DropColumn("dbo.PurchaseInformations", "Vendor");
        }
    }
}
