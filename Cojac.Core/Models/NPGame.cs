using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cojac.Core.Models
{
    public class NPGame
    {
        public int      SeriesId       { get; set; }  // Series identifer (FK: NPSeries)
        public Int32    Game           { get; set; }  // Game number (1-7)
        public DateTime DateTime       { get; set; }  // Game date / start time
        public Int32    HigerSeedScore { get; set; }  // Score of higher-ranked team
        public Int32    LowerSeedScore { get; set; }  // Score of lower-ranked team 
        public bool     SeriesWon      { get; set; }  // Was series won with this game
    }
}