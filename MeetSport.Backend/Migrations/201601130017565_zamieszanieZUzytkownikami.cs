namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zamieszanieZUzytkownikami : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IdentityUserClaims", "UserId", "dbo.Users");
            DropForeignKey("dbo.IdentityUserLogins", "User_Id", "dbo.Users");
            DropForeignKey("dbo.IdentityUserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "Founder_Id", "dbo.Users");
            DropForeignKey("dbo.EventUsers", "Player_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Ratings", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.UserFriends", "Friend_Id", "dbo.Users");
            DropForeignKey("dbo.UserFriends", "User_Id", "dbo.Users");
            DropIndex("dbo.Events", new[] { "Founder_Id" });
            DropIndex("dbo.IdentityUserClaims", new[] { "UserId" });
            DropIndex("dbo.IdentityUserLogins", new[] { "User_Id" });
            DropIndex("dbo.IdentityUserRoles", new[] { "UserId" });
            DropIndex("dbo.EventUsers", new[] { "Player_Id" });
            DropIndex("dbo.Ratings", new[] { "Author_Id" });
            DropIndex("dbo.Ratings", new[] { "Owner_Id" });
            DropIndex("dbo.UserFriends", new[] { "Friend_Id" });
            DropIndex("dbo.UserFriends", new[] { "User_Id" });
            AddColumn("dbo.Events", "FounderName", c => c.String());
            AddColumn("dbo.EventUsers", "UserName", c => c.String());
            AddColumn("dbo.Ratings", "OwnerName", c => c.String());
            AddColumn("dbo.Ratings", "AuthorName", c => c.String());
            AddColumn("dbo.UserFriends", "UserName", c => c.String());
            AddColumn("dbo.UserFriends", "FriendName", c => c.String());
            DropColumn("dbo.Events", "FounderId");
            DropColumn("dbo.Events", "Founder_Id");
            DropColumn("dbo.IdentityUserLogins", "User_Id");
            DropColumn("dbo.EventUsers", "PlayerId");
            DropColumn("dbo.EventUsers", "Player_Id");
            DropColumn("dbo.Ratings", "OwnerId");
            DropColumn("dbo.Ratings", "AuthorId");
            DropColumn("dbo.Ratings", "Author_Id");
            DropColumn("dbo.Ratings", "Owner_Id");
            DropColumn("dbo.UserFriends", "UserId");
            DropColumn("dbo.UserFriends", "FriendId");
            DropColumn("dbo.UserFriends", "Friend_Id");
            DropColumn("dbo.UserFriends", "User_Id");
            DropTable("dbo.Users");
            DropTable("dbo.IdentityUserClaims");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IdentityUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.UserFriends", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.UserFriends", "Friend_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.UserFriends", "FriendId", c => c.Int(nullable: false));
            AddColumn("dbo.UserFriends", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "Owner_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Ratings", "Author_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Ratings", "AuthorId", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "OwnerId", c => c.Int(nullable: false));
            AddColumn("dbo.EventUsers", "Player_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.EventUsers", "PlayerId", c => c.Int(nullable: false));
            AddColumn("dbo.IdentityUserLogins", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Events", "Founder_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Events", "FounderId", c => c.Int(nullable: false));
            DropColumn("dbo.UserFriends", "FriendName");
            DropColumn("dbo.UserFriends", "UserName");
            DropColumn("dbo.Ratings", "AuthorName");
            DropColumn("dbo.Ratings", "OwnerName");
            DropColumn("dbo.EventUsers", "UserName");
            DropColumn("dbo.Events", "FounderName");
            CreateIndex("dbo.UserFriends", "User_Id");
            CreateIndex("dbo.UserFriends", "Friend_Id");
            CreateIndex("dbo.Ratings", "Owner_Id");
            CreateIndex("dbo.Ratings", "Author_Id");
            CreateIndex("dbo.EventUsers", "Player_Id");
            CreateIndex("dbo.IdentityUserRoles", "UserId");
            CreateIndex("dbo.IdentityUserLogins", "User_Id");
            CreateIndex("dbo.IdentityUserClaims", "UserId");
            CreateIndex("dbo.Events", "Founder_Id");
            AddForeignKey("dbo.UserFriends", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UserFriends", "Friend_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Ratings", "Owner_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Ratings", "Author_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.EventUsers", "Player_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Events", "Founder_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.IdentityUserRoles", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.IdentityUserLogins", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.IdentityUserClaims", "UserId", "dbo.Users", "Id");
        }
    }
}
