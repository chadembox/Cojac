using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CojacModel.Models
{
    public class NPGame
    {
        public string   SeriesID { get; set; }      // Series identifer (FK: NPSeries)
        public Int32    Game { get; set; }          // Game number (1-7)
        public DateTime GameDateTime { get; set; }  // Game date / start time
        public Int32    Team1Score { get; set; }    // Score of higher-ranked team
        public Int32    Team2Score { get; set; }    // Score of lower-ranked team 
        public bool     SeriesWon { get; set; }     // Was series won with this game
    }
}