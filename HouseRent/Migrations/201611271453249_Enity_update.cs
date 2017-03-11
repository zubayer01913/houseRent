namespace HouseRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enity_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentInformations", "TypeName", c => c.String());
            DropColumn("dbo.RentInformations", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RentInformations", "Type", c => c.String());
            DropColumn("dbo.RentInformations", "TypeName");
        }
    }
}
