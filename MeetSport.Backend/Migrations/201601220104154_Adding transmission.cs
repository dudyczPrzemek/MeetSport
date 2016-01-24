namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addingtransmission : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        OwnerName = c.String(),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transmissions");
        }
    }
}
