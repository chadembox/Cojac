using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CojacModel.Models
{
    public class NPSeries
    {
        public string   SeriesID { get; set; }          // E1, W2, (F)inal, (C)hampion, (D)ark Horse
        public Int16    Round { get; set;  }            // 1, 2, 3, 4
        public string   Team1 { get; set;  }            // Higher-ranked team
        public Int16    Team1Wins { get; set; }         // Number of wins for higher-ranked team (FK: NPTeam)
        public string   Team2 { get; set;  }            // Lower-ranked team
        public string   Team2Wins { get; set; }         // Number of wins for lower-ranked team (FK: NPTeam)
    }
}