using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cojac.Core.Models
{
    public class NPPick
    {
        public int      PickId           { get; set; }
        public Int32    UserId           { get; set; }  // User who made pick (FK: JUser)
        public DateTime DateTime         { get; set; }  // Date/time pick was made
        public NPSeries Series           { get; set; }  // Series identifier (FK: NPSeries)
        public Int32    PickedBeforeGame { get; set; }  // What game pick was made before (1-7)
        public NPTeam   TeamPick         { get; set; }  // Predicted winner (FK: NPTeam)
        public Int32    GamePick         { get; set; }  // Game series will be clinched on (1-7)
        public Int32    PotentialPoints  { get; set; }  // Potential points for this pick
        public Int32    Points           { get; set; }  // Actual points scored for this pick        
        public bool     IsActivePick     { get; set; }  // Most recent pick
    }
}