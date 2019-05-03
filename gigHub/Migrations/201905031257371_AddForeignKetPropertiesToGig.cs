namespace gigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKetPropertiesToGig : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.gigs", name: "Artist_Id", newName: "ArtistId");
            RenameColumn(table: "dbo.gigs", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.gigs", name: "IX_Artist_Id", newName: "IX_ArtistId");
            RenameIndex(table: "dbo.gigs", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.gigs", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.gigs", name: "IX_ArtistId", newName: "IX_Artist_Id");
            RenameColumn(table: "dbo.gigs", name: "GenreId", newName: "Genre_Id");
            RenameColumn(table: "dbo.gigs", name: "ArtistId", newName: "Artist_Id");
        }
    }
}
