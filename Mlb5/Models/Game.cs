using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mlb5.Models
{
    public class Game
    {
        public Game()
        {
            AwayTeam = new GameTeam();
            HomeTeam = new GameTeam();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string StringId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan ElapsedTime
        {
            get;
            set;
        }
        public DateTime EndTime { get; set; }

        public GameTeam AwayTeam { get; set; }
        public GameTeam HomeTeam { get; set; }
        public string ElapsedTimeString { get; set; }
        public int ElapsedTimeHours { get; set; }
        public int ElapsedTimeMinutes { get; set; }
    }

    public class GameTeam
    {
        public int TeamId { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public  int Runs { get; set; }
        public int Homeruns { get; set; }
        public int Strikeouts { get; set; }
        public string Record { get; set; }
    }
}