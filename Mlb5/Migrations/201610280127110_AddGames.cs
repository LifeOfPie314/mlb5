namespace Mlb5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
