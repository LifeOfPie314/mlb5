namespace Mlb5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLots : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        StringId = c.String(),
                        Date = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        ElapsedTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.DateTime(nullable: false),
                        AwayTeam_TeamId = c.Int(nullable: false),
                        AwayTeam_Code = c.String(),
                        AwayTeam_City = c.String(),
                        AwayTeam_Name = c.String(),
                        AwayTeam_Runs = c.Int(nullable: false),
                        AwayTeam_Homeruns = c.Int(nullable: false),
                        AwayTeam_Strikeouts = c.Int(nullable: false),
                        AwayTeam_Record = c.String(),
                        HomeTeam_TeamId = c.Int(nullable: false),
                        HomeTeam_Code = c.String(),
                        HomeTeam_City = c.String(),
                        HomeTeam_Name = c.String(),
                        HomeTeam_Runs = c.Int(nullable: false),
                        HomeTeam_Homeruns = c.Int(nullable: false),
                        HomeTeam_Strikeouts = c.Int(nullable: false),
                        HomeTeam_Record = c.String(),
                        ElapsedTimeString = c.String(),
                        ElapsedTimeHours = c.Int(nullable: false),
                        ElapsedTimeMinutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Picks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TeamCode = c.String(),
                        Homeruns = c.Int(nullable: false),
                        Strikeouts = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Game_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
            CreateTable(
                "dbo.SimulationDateTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Hours = c.Int(nullable: false),
                        Minutes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Picks", "Game_Id", "dbo.Games");
            DropIndex("dbo.Picks", new[] { "Game_Id" });
            DropTable("dbo.SimulationDateTimes");
            DropTable("dbo.Picks");
            DropTable("dbo.Games");
        }
    }
}
