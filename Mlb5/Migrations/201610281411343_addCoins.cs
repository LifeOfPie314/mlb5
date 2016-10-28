namespace Mlb5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCoins : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Coins", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Coins");
        }
    }
}
