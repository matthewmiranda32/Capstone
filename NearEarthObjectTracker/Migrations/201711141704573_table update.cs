namespace NearEarthObjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NearEarthObjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Asteroid_Name = c.String(),
                        Estimated_Diameter_Max_Kms = c.Double(nullable: false),
                        isAsteroidDangerous = c.String(),
                        closest_Approach_Earth_Date = c.String(),
                        miss_Distance = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NearEarthObjects");
        }
    }
}
