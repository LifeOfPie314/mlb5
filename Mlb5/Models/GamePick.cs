using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mlb5.Models
{
    public class GamePick
    {
        public GamePick()
        {
            AwayTeam = new GamePickTeam();
            HomeTeam = new GamePickTeam();
        }

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

        public GamePickTeam AwayTeam { get; set; }
        public GamePickTeam HomeTeam { get; set; }
        public string ElapsedTimeString { get; set; }
        public int ElapsedTimeHours { get; set; }
        public int ElapsedTimeMinutes { get; set; }
        public bool Picked { get; set; }
        public int PickId { get; set; }
        public DateTime LocalTime { get; set; }

        public void MarkPicked(Pick pick)
        {
            Picked = true;
            PickId = pick.Id;
            if (AwayTeam.Code == pick.TeamCode)
            {
                AwayTeam.MarkPicked();
            }
            else
            {
                HomeTeam.MarkPicked();
            }
        }

        public void SetTime()
        {
            LocalTime = StartTime.AddHours(-6);
        }
    }

    public class GamePickTeam
    {
        public int TeamId { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public int Runs { get; set; }
        public int Homeruns { get; set; }
        public int Strikeouts { get; set; }
        public string Record { get; set; }
        public bool Picked { get; set; }


        public void MarkPicked()
        {
            Picked = true;
        }
    }

}