namespace Mlb5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRuns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Picks", "Runs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Picks", "Runs");
        }
    }
}
