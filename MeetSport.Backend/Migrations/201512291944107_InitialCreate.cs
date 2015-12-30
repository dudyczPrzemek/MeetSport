namespace MeetSport.Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
