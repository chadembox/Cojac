using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cojac.Core.Models
{
    public class Contest
    {
        public string Id             { get; set; }
        public int Year              { get; set; }
        public DateTime StartDate    { get; set; }
        public DateTime EndDate      { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Winner         { get; set; }
        public string PicturePath    { get; set; }
        public string Caption        { get; set; }
        public string Details        { get; set; }
        public int UserCount         { get; set; }
    }
}
