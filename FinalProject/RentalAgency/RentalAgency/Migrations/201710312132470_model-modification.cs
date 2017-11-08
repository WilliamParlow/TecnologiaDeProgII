namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelmodification : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
        }
    }
}
