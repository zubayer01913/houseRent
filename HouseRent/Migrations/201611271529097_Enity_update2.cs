namespace HouseRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enity_update2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RentInformations", "FlatOrShopNo", c => c.String(nullable: false));
            AlterColumn("dbo.RentInformations", "TypeName", c => c.String(nullable: false));
            AlterColumn("dbo.RentInformations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.RentInformations", "Bill", c => c.Double());
            AlterColumn("dbo.RentInformations", "Due", c => c.Double());
            AlterColumn("dbo.RentInformations", "Amount", c => c.Double());
            AlterColumn("dbo.RentInformations", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RentInformations", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RentInformations", "Amount", c => c.Double(nullable: false));
            AlterColumn("dbo.RentInformations", "Due", c => c.Double(nullable: false));
            AlterColumn("dbo.RentInformations", "Bill", c => c.Double(nullable: false));
            AlterColumn("dbo.RentInformations", "Name", c => c.String());
            AlterColumn("dbo.RentInformations", "TypeName", c => c.String());
            AlterColumn("dbo.RentInformations", "FlatOrShopNo", c => c.String());
        }
    }
}
