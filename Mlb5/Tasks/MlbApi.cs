using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Mlb5.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mlb5.Tasks
{
    public class MlbApi
    {
        public async Task<List<MasterScoreboardApiGame>> Get(DateTime date)
        {
            var apiurl = GetBaseApiUrl(date);
            var file = "master_scoreboard.json";
            string response;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetStringAsync(apiurl + file);
            }
            var masterScoreboard = JObject.Parse(response);

            var gameNodes = masterScoreboard["data"]["games"]["game"].Children().ToList();

            var gamesList = new List<MasterScoreboardApiGame>();
            foreach (var gameNode in gameNodes)
            {
                var apiGame = JsonConvert.DeserializeObject<MasterScoreboardApiGame>(gameNode.ToString());
                try
                {
                    var linescore = gameNode["linescore"];
                    var linescoreString = gameNode["linescore"].ToString();
                    var hr = linescore["hr"].ToString();
                    var away = linescore["hr"]["away"].ToString();

                    apiGame.away_homeruns = Convert.ToInt32(linescore["hr"]["away"].ToString());
                    apiGame.away_strikeouts = Convert.ToInt32(linescore["so"]["away"].ToString());
                    apiGame.away_score = Convert.ToInt32(linescore["r"]["away"].ToString());


                    apiGame.home_homeruns = Convert.ToInt32(linescore["hr"]["home"].ToString());
                    apiGame.home_strikeouts = Convert.ToInt32(linescore["so"]["home"].ToString());
                    apiGame.home_score = Convert.ToInt32(linescore["r"]["home"].ToString());
                }
                catch (Exception ex)
                {
                    apiGame.Canceled = true;
                }

                gamesList.Add(apiGame);
            }

            return gamesList;
        }

        public static string GetBaseApiUrl(DateTime date)
        {
            var apiurl = string.Format("http://gd.mlb.com/components/game/mlb/year_{0:yyyy}/month_{0:MM}/day_{0:dd}/",
                date);
            return apiurl;
        }

        public async Task<List<Game>> GetGameFiles(DateTime date)
        {
            var masterScoreboardApiGames = await Get(date);
            var url = GetBaseApiUrl(date);

            using (var httpClient = new HttpClient())
            {
                foreach (var scoreboardApiGame in masterScoreboardApiGames)
                {
                    if (!scoreboardApiGame.Canceled)
                    {
                        var boxScoreXml = await httpClient.GetStringAsync(url + scoreboardApiGame.GetBoxScoreUrl());
                        scoreboardApiGame.AddBoxScoreXml(boxScoreXml);
                    }
                }
            }

            var games = new List<Game>();

            foreach (var apiGame in masterScoreboardApiGames)
            {
                games.Add(apiGame.MapToGame(date));
            }

            return games;
        }


    }

    public class MasterScoreboardApiGame
    {
        private string _boxScoreXml;
        public string id { get; set; }
        public string game_pk { get; set; }
        public string time_hm_lg { get; set; }
        public string time_zone_hm_lg { get; set; }
        public string hm_lg_ampm { get; set; }

        public int away_team_id { get; set; }
        public string away_code { get; set; }
        public string away_team_city { get; set; }
        public string away_team_name { get; set; }
        public int away_win { get; set; }
        public int away_loss { get; set; }

        public int away_score { get; set; }
        public int away_homeruns { get; set; }
        public int away_strikeouts { get; set; }


        public int home_team_id { get; set; }
        public string home_code { get; set; }
        public string home_team_city { get; set; }
        public string home_team_name { get; set; }
        public int home_win { get; set; }
        public int home_loss { get; set; }

        public int home_score { get; set; }
        public int home_homeruns { get; set; }
        public int home_strikeouts { get; set; }
        public bool Canceled { get; set; }

        public string GetBoxScoreUrl()
        {
            return "gid_" + id.Replace('/', '_').Replace('-', '_') + "/rawboxscore.xml";
        }

        public void AddBoxScoreXml(string boxScoreXml)
        {
            _boxScoreXml = boxScoreXml;
        }

        public Game MapToGame(DateTime date)
        {
            var game = new Game();

            game.Id = id;
            game.Date = date;
            game.AwayTeam.TeamId = away_team_id;
            game.AwayTeam.Code = away_code;
            game.AwayTeam.City = away_team_city;
            game.AwayTeam.Name = away_team_name;
            game.AwayTeam.Runs = away_score;
            game.AwayTeam.Homeruns = away_homeruns;
            game.AwayTeam.Strikeouts = away_strikeouts;
            game.AwayTeam.Record = $"{away_win}-{away_loss}";

            game.HomeTeam.TeamId = home_team_id;
            game.HomeTeam.Code = home_code;
            game.HomeTeam.City = home_team_city;
            game.HomeTeam.Name = home_team_name;
            game.HomeTeam.Runs = home_score;
            game.HomeTeam.Homeruns = home_homeruns;
            game.HomeTeam.Strikeouts = home_strikeouts;
            game.HomeTeam.Record = $"{home_win}-{home_loss}";



            var timeSplit = time_hm_lg.Split(':');
            int hours = Convert.ToInt32(timeSplit[0]);
            int minutes = Convert.ToInt32(timeSplit[1]);

            if (hm_lg_ampm == "PM")
                hours = hours + 12;

            hours = hours + Convert.ToInt32(time_zone_hm_lg);


            game.StartTime = DateTime.SpecifyKind(new DateTime(date.Year, date.Month, date.Day, hours, minutes, 0),
                DateTimeKind.Utc);

            // Parse XML
            if (!String.IsNullOrEmpty(_boxScoreXml))
            {

                XDocument doc = XDocument.Parse(_boxScoreXml);
                var boxscoreNode = doc.Root;

                var elapsedTime = boxscoreNode.Attribute("elapsed_time").Value.Substring(0, 4);
                game.ElapsedTimeString = elapsedTime;
                game.ElapsedTimeHours = Convert.ToInt32(elapsedTime[0]);
                game.ElapsedTimeMinutes = Convert.ToInt32(elapsedTime[1]);
                var elapsedTimeXml = elapsedTime.Split(':');
                try
                {
                    //game.ElapsedTime = new TimeSpan(0, Convert.ToInt32(elapsedTime[0]), Convert.ToInt32(elapsedTime[1]), 0);
                    game.EndTime = game.StartTime.Add(game.ElapsedTime);
                }
                catch (Exception ex)
                {
                    //game.ElapsedTime = new TimeSpan(0, 3, 0, 0);
                    game.EndTime = game.StartTime.Add(game.ElapsedTime);
                }
            }
            else
            {
                game.EndTime = game.StartTime;
            }
            //Map to XML
            //game.Raw = _boxScoreXml;

            return game;
        }
    }
}