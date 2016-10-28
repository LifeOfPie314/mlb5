using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mlb5.Models
{
    public class SimulationDateTime
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public DateTime GetCurrentTime()
        {
            return Date.AddHours(Hours).AddMinutes(Minutes);
        }
    }
}