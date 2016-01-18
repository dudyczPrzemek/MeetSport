namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uzytkownik : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "FounderId_Id", newName: "Founder_Id");
            RenameIndex(table: "dbo.Events", name: "IX_FounderId_Id", newName: "IX_Founder_Id");
            AddColumn("dbo.Events", "FounderId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "FounderId");
            RenameIndex(table: "dbo.Events", name: "IX_Founder_Id", newName: "IX_FounderId_Id");
            RenameColumn(table: "dbo.Events", name: "Founder_Id", newName: "FounderId_Id");
        }
    }
}
