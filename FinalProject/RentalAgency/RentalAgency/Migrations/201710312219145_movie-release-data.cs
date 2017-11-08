namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moviereleasedata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Date");
        }
    }
}
