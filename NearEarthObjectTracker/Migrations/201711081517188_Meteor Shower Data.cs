namespace NearEarthObjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeteorShowerData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meteor_Showers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        showerName = c.String(),
                        dateOfVisibility = c.String(),
                        moonPhase = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Meteor_Showers");
        }
    }
}
