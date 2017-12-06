namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Costumers", "canEdit", c => c.Boolean(nullable: false));
            AddColumn("dbo.Costumers", "ImageUrl", c => c.String());
            DropColumn("dbo.Costumers", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Costumers", "UserID", c => c.String(nullable: false));
            DropColumn("dbo.Costumers", "ImageUrl");
            DropColumn("dbo.Costumers", "canEdit");
        }
    }
}
