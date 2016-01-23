namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        XCoordynates = c.Int(nullable: false),
                        YCoordynates = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FounderName = c.String(),
                        SportId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        PlayersNeeded = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        EventDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(),
                        AuthorName = c.String(),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        TypeId = c.Int(),
                        Name = c.String(),
                        CustomerColor = c.Int(),
                        Date = c.DateTime(nullable: false),
                        Number = c.String(),
                        IsInternal = c.Boolean(),
                        Amount = c.Int(),
                        PlannedTime = c.Int(),
                        PlannedStartDate = c.DateTime(),
                        PlannedEndDate = c.DateTime(),
                        Color = c.Int(),
                        PlanningDate = c.DateTime(),
                        Description = c.String(),
                        ModificationDate = c.DateTime(),
                        Progress = c.Int(nullable: false),
                        ModificationBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserFriends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FriendName = c.String(),
                        FriendshipStartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventUsers", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Events", "AddressId", "dbo.Address");
            DropIndex("dbo.EventUsers", new[] { "EventId" });
            DropIndex("dbo.Events", new[] { "AddressId" });
            DropIndex("dbo.Events", new[] { "SportId" });
            DropTable("dbo.UserFriends");
            DropTable("dbo.Tasks");
            DropTable("dbo.Ratings");
            DropTable("dbo.EventUsers");
            DropTable("dbo.Sports");
            DropTable("dbo.Events");
            DropTable("dbo.Address");
        }
    }
}
