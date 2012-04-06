using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Models
{
    public class NPUser : JUser
    {
        public ICollection<NPPick> Picks { get; set; }

        public int CurrentPoints
        {
            get
            {
                return Picks.Sum(p => p.Points);
            }
        }

        public int PotentialPoints
        {
            get
            {
                return Picks.Sum(p => p.PotentialPoints);
            }
        }

    }
}
