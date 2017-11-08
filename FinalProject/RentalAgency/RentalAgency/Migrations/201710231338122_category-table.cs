namespace RentalAgency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Category_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Category_Id");
            AddForeignKey("dbo.Movies", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            DropForeignKey("dbo.Movies", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "Category_Id" });
            DropColumn("dbo.Movies", "Category_Id");
            DropTable("dbo.Categories");
        }
    }
}
