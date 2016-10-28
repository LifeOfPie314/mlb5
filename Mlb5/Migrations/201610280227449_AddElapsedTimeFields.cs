namespace Mlb5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddElapsedTimeFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ElapsedTimeHours", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "ElapsedTimeMinutes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "ElapsedTimeMinutes");
            DropColumn("dbo.Games", "ElapsedTimeHours");
        }
    }
}
