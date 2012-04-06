using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cojac.Core.Models
{
    public class NPSeries
    {
        public int      SeriesId            { get; set; }     // What Jeaux Hates, unimportant number
        public NPRound  Round               { get; set; }     // E1, W1
        public NPTeam   HigherSeed          { get; set; }     // Higher-ranked team
        public Int16    HigherSeedWinTotal  { get; set; }     // Number of wins for higher-ranked team (FK: NPTeam)
        public NPTeam   LowerSeed           { get; set; }     // Lower-ranked team
        public Int16    LowerSeedWinTotal   { get; set; }     // Number of wins for lower-ranked team (FK: NPTeam)

        public ICollection<NPGame> Games    { get; set; }
    }
}