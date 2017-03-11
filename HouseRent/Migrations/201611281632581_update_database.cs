namespace HouseRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_database : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentInformations", "FloorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentInformations", "FloorName");
        }
    }
}
