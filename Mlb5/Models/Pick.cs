using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mlb5.Models
{
    public class Pick
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Game Game { get; set; }
        public string TeamCode { get; set; }
        public int Runs { get; set; }
        public int Homeruns { get; set; }
        public int Strikeouts { get; set; }
        public PickStatus Status { get; set; }
    }

    public enum PickStatus
    {
        New,
        Won,
        Lost
    }
}