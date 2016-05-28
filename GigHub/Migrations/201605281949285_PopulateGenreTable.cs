namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Jazz')");
            Sql("INSERT INTO Genres(Name) VALUES('Pop')");
            Sql("INSERT INTO Genres(Name) VALUES('Hiphop')");
            Sql("INSERT INTO Genres(Name) VALUES('Rock')");
            Sql("INSERT INTO Genres(Name) VALUES('Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name IN ('Jazz', 'Pop', 'Hiphop', 'Rock', 'Country')");
        }
    }
}
