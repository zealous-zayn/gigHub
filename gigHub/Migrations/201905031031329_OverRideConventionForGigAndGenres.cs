namespace gigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverRideConventionForGigAndGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.gigs", "Artist_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.gigs", new[] { "Artist_Id" });
            DropIndex("dbo.gigs", new[] { "Genre_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.gigs", "Artist_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.gigs", "Genre_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.gigs", "Artist_Id");
            CreateIndex("dbo.gigs", "Genre_Id");
            AddForeignKey("dbo.gigs", "Artist_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.gigs", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.gigs", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.gigs", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.gigs", new[] { "Genre_Id" });
            DropIndex("dbo.gigs", new[] { "Artist_Id" });
            AlterColumn("dbo.gigs", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.gigs", "Artist_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.gigs", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.gigs", "Genre_Id");
            CreateIndex("dbo.gigs", "Artist_Id");
            AddForeignKey("dbo.gigs", "Genre_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.gigs", "Artist_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
