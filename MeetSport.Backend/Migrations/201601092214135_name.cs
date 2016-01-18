namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "AddressId_Id", "dbo.Address");
            DropForeignKey("dbo.Events", "SportId_Id", "dbo.Sports");
            DropForeignKey("dbo.EventUsers", "EventId_Id", "dbo.Events");
            DropIndex("dbo.Events", new[] { "AddressId_Id" });
            DropIndex("dbo.Events", new[] { "SportId_Id" });
            DropIndex("dbo.EventUsers", new[] { "EventId_Id" });
            RenameColumn(table: "dbo.Events", name: "AddressId_Id", newName: "AddressId");
            RenameColumn(table: "dbo.Events", name: "SportId_Id", newName: "SportId");
            RenameColumn(table: "dbo.EventUsers", name: "EventId_Id", newName: "EventId");
            RenameColumn(table: "dbo.EventUsers", name: "PlayerId_Id", newName: "Player_Id");
            RenameColumn(table: "dbo.Ratings", name: "AuthorId_Id", newName: "Author_Id");
            RenameColumn(table: "dbo.Ratings", name: "OwnerId_Id", newName: "Owner_Id");
            RenameColumn(table: "dbo.UserFriends", name: "FriendId_Id", newName: "Friend_Id");
            RenameColumn(table: "dbo.UserFriends", name: "UserId_Id", newName: "User_Id");
            RenameIndex(table: "dbo.EventUsers", name: "IX_PlayerId_Id", newName: "IX_Player_Id");
            RenameIndex(table: "dbo.Ratings", name: "IX_AuthorId_Id", newName: "IX_Author_Id");
            RenameIndex(table: "dbo.Ratings", name: "IX_OwnerId_Id", newName: "IX_Owner_Id");
            RenameIndex(table: "dbo.UserFriends", name: "IX_FriendId_Id", newName: "IX_Friend_Id");
            RenameIndex(table: "dbo.UserFriends", name: "IX_UserId_Id", newName: "IX_User_Id");
            AddColumn("dbo.EventUsers", "PlayerId", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "OwnerId", c => c.Int(nullable: false));
            AddColumn("dbo.Ratings", "AuthorId", c => c.Int(nullable: false));
            AddColumn("dbo.UserFriends", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.UserFriends", "FriendId", c => c.Int(nullable: false));
            AlterColumn("dbo.Events", "AddressId", c => c.Int(nullable: false));
            AlterColumn("dbo.Events", "SportId", c => c.Int(nullable: false));
            AlterColumn("dbo.EventUsers", "EventId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "SportId");
            CreateIndex("dbo.Events", "AddressId");
            CreateIndex("dbo.EventUsers", "EventId");
            AddForeignKey("dbo.Events", "AddressId", "dbo.Address", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "SportId", "dbo.Sports", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventUsers", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventUsers", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Events", "AddressId", "dbo.Address");
            DropIndex("dbo.EventUsers", new[] { "EventId" });
            DropIndex("dbo.Events", new[] { "AddressId" });
            DropIndex("dbo.Events", new[] { "SportId" });
            AlterColumn("dbo.EventUsers", "EventId", c => c.Int());
            AlterColumn("dbo.Events", "SportId", c => c.Int());
            AlterColumn("dbo.Events", "AddressId", c => c.Int());
            DropColumn("dbo.UserFriends", "FriendId");
            DropColumn("dbo.UserFriends", "UserId");
            DropColumn("dbo.Ratings", "AuthorId");
            DropColumn("dbo.Ratings", "OwnerId");
            DropColumn("dbo.EventUsers", "PlayerId");
            RenameIndex(table: "dbo.UserFriends", name: "IX_User_Id", newName: "IX_UserId_Id");
            RenameIndex(table: "dbo.UserFriends", name: "IX_Friend_Id", newName: "IX_FriendId_Id");
            RenameIndex(table: "dbo.Ratings", name: "IX_Owner_Id", newName: "IX_OwnerId_Id");
            RenameIndex(table: "dbo.Ratings", name: "IX_Author_Id", newName: "IX_AuthorId_Id");
            RenameIndex(table: "dbo.EventUsers", name: "IX_Player_Id", newName: "IX_PlayerId_Id");
            RenameColumn(table: "dbo.UserFriends", name: "User_Id", newName: "UserId_Id");
            RenameColumn(table: "dbo.UserFriends", name: "Friend_Id", newName: "FriendId_Id");
            RenameColumn(table: "dbo.Ratings", name: "Owner_Id", newName: "OwnerId_Id");
            RenameColumn(table: "dbo.Ratings", name: "Author_Id", newName: "AuthorId_Id");
            RenameColumn(table: "dbo.EventUsers", name: "Player_Id", newName: "PlayerId_Id");
            RenameColumn(table: "dbo.EventUsers", name: "EventId", newName: "EventId_Id");
            RenameColumn(table: "dbo.Events", name: "SportId", newName: "SportId_Id");
            RenameColumn(table: "dbo.Events", name: "AddressId", newName: "AddressId_Id");
            CreateIndex("dbo.EventUsers", "EventId_Id");
            CreateIndex("dbo.Events", "SportId_Id");
            CreateIndex("dbo.Events", "AddressId_Id");
            AddForeignKey("dbo.EventUsers", "EventId_Id", "dbo.Events", "Id");
            AddForeignKey("dbo.Events", "SportId_Id", "dbo.Sports", "Id");
            AddForeignKey("dbo.Events", "AddressId_Id", "dbo.Address", "Id");
        }
    }
}
