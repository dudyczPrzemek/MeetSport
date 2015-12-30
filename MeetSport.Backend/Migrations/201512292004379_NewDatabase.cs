namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabase : DbMigration
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
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        PlayersNeeded = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        EventDescription = c.String(),
                        AddressId_Id = c.Int(),
                        FounderId_Id = c.String(maxLength: 128),
                        SportId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId_Id)
                .ForeignKey("dbo.Users", t => t.FounderId_Id)
                .ForeignKey("dbo.Sports", t => t.SportId_Id)
                .Index(t => t.AddressId_Id)
                .Index(t => t.FounderId_Id)
                .Index(t => t.SportId_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ExternalUserId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.IdentityUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.IdentityUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.IdentityRoles", t => t.IdentityRole_Id)
                .Index(t => t.UserId)
                .Index(t => t.IdentityRole_Id);
            
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
                        EventId_Id = c.Int(),
                        PlayerId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId_Id)
                .ForeignKey("dbo.Users", t => t.PlayerId_Id)
                .Index(t => t.EventId_Id)
                .Index(t => t.PlayerId_Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(),
                        AuthorId_Id = c.String(maxLength: 128),
                        OwnerId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AuthorId_Id)
                .ForeignKey("dbo.Users", t => t.OwnerId_Id)
                .Index(t => t.AuthorId_Id)
                .Index(t => t.OwnerId_Id);
            
            CreateTable(
                "dbo.UserFriends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FriendshipStartDate = c.DateTime(nullable: false),
                        FriendId_Id = c.String(maxLength: 128),
                        UserId_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.FriendId_Id)
                .ForeignKey("dbo.Users", t => t.UserId_Id)
                .Index(t => t.FriendId_Id)
                .Index(t => t.UserId_Id);
            
            CreateTable(
                "dbo.IdentityRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.UserFriends", "UserId_Id", "dbo.Users");
            DropForeignKey("dbo.UserFriends", "FriendId_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "OwnerId_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "AuthorId_Id", "dbo.Users");
            DropForeignKey("dbo.EventUsers", "PlayerId_Id", "dbo.Users");
            DropForeignKey("dbo.EventUsers", "EventId_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "SportId_Id", "dbo.Sports");
            DropForeignKey("dbo.Events", "FounderId_Id", "dbo.Users");
            DropForeignKey("dbo.IdentityUserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.IdentityUserLogins", "User_Id", "dbo.Users");
            DropForeignKey("dbo.IdentityUserClaims", "UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "AddressId_Id", "dbo.Address");
            DropIndex("dbo.UserFriends", new[] { "UserId_Id" });
            DropIndex("dbo.UserFriends", new[] { "FriendId_Id" });
            DropIndex("dbo.Ratings", new[] { "OwnerId_Id" });
            DropIndex("dbo.Ratings", new[] { "AuthorId_Id" });
            DropIndex("dbo.EventUsers", new[] { "PlayerId_Id" });
            DropIndex("dbo.EventUsers", new[] { "EventId_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "UserId" });
            DropIndex("dbo.IdentityUserLogins", new[] { "User_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "UserId" });
            DropIndex("dbo.Events", new[] { "SportId_Id" });
            DropIndex("dbo.Events", new[] { "FounderId_Id" });
            DropIndex("dbo.Events", new[] { "AddressId_Id" });
            DropTable("dbo.IdentityRoles");
            DropTable("dbo.UserFriends");
            DropTable("dbo.Ratings");
            DropTable("dbo.EventUsers");
            DropTable("dbo.Sports");
            DropTable("dbo.IdentityUserRoles");
            DropTable("dbo.IdentityUserLogins");
            DropTable("dbo.IdentityUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Events");
            DropTable("dbo.Address");
        }
    }
}
