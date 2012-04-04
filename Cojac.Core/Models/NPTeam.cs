using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CojacModel.Models
{
    public class NPTeam
    {
        public string TeamID { get; set;  }     // Team identifier (TE1, TW2)
        public string TeamName { get; set; }    // NBA team (Thunder, Trailblazers, etc.)
        public Int32 TeamRank { get; set;  }    // 1-8
    }
}