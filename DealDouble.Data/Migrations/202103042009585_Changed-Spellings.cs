namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSpellings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auctions", "PicturesUrl", c => c.String());
            DropColumn("dbo.Auctions", "PictureUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "PictureUrl", c => c.String());
            DropColumn("dbo.Auctions", "PicturesUrl");
        }
    }
}
