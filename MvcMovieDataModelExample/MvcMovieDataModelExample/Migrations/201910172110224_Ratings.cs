namespace MvcMovieDataModelExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ratings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RatingName = c.String(nullable: false, maxLength: 64),
                        LastModified = c.DateTime(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Movies", "RatingID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "RatingID");
            AddForeignKey("dbo.Movies", "RatingID", "dbo.Ratings", "ID", cascadeDelete: true);
            DropColumn("dbo.Movies", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
            DropForeignKey("dbo.Movies", "RatingID", "dbo.Ratings");
            DropIndex("dbo.Movies", new[] { "RatingID" });
            DropColumn("dbo.Movies", "RatingID");
            DropTable("dbo.Ratings");
        }
    }
}
