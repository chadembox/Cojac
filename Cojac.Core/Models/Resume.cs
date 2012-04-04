using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cojac.Core.Models
{
    public class Resume
    {
        public int UserId { get; set; }
        public string ContestId { get; set; }
        public int ContestYear { get; set; }
        public short Place { get; set; }
        public string Points { get; set; }
    }
}
