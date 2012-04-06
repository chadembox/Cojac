using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cojac.Core.Models
{
    public class NPTeam
    {
        public string TeamId { get; set;  }     // Team identifier (TE1, TW2)
        public string Name   { get; set; }    // NBA team (Thunder, Trailblazers, etc.)
        public Int32 Rank    { get; set;  }    // 1-8
    }
}