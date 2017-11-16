namespace NearEarthObjectTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NearEarthObjects", "miss_Distance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NearEarthObjects", "miss_Distance", c => c.String());
        }
    }
}
