namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transmissiondetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transmissions", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transmissions", "Title");
        }
    }
}
