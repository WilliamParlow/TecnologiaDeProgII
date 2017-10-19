namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moviemodelmodified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Descricao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Descricao", c => c.String());
            AlterColumn("dbo.Movies", "Genre", c => c.String());
        }
    }
}
