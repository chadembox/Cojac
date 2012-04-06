using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cojac.Core.Models
{
    public class NPRound
    {
        public string RoundId { get; set; }   //E1, W1, E2
        public string Name    { get; set; } //Eastern First Round, Semifinals, Conference Finals

        public ICollection<NPSeries> Series { get; set; }
    }
}
