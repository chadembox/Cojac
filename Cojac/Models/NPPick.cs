using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CojacModel.Models
{
    public class NPPick
    {
        public Int32    UserID { get; set; }            // User who made pick (FK: JUser)
        public DateTime PickDateTime { get; set; }      // Date/time pick was made
        public string   SeriesID { get; set; }          // Series identifier (FK: NPSeries)
        public Int32    PickedBeforeGame { get; set; }  // What game pick was made before (1-7)
        public string   TeamPick { get; set; }          // Predicted winner (FK: NPTeam)
        public Int32    GamePick { get; set; }          // Game series will be clinched on (1-7)
        public Int32    PotentialPoints { get; set; }   // Potential points for this pick
        public Int32    Points { get; set; }            // Actual points scored for this pick

        // Collection of previous picks??
    }
}