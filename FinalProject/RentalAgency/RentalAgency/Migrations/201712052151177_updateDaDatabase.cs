namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDaDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Costumers", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Costumers", "UserID", c => c.String(nullable: false));
            DropColumn("dbo.Costumers", "PurchasedMovies");
            DropColumn("dbo.Costumers", "PurchasedGames");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Costumers", "PurchasedGames", c => c.Int(nullable: false));
            AddColumn("dbo.Costumers", "PurchasedMovies", c => c.Int(nullable: false));
            AlterColumn("dbo.Costumers", "UserID", c => c.String());
            AlterColumn("dbo.Costumers", "Email", c => c.String());
        }
    }
}
