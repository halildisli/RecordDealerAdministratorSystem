namespace RecordDealer.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ArtistName = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Double(nullable: false),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        DateOfRegistration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Albums");
        }
    }
}
