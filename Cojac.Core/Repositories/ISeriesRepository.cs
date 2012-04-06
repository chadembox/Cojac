using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public interface ISeriesRepository
    {
        ICollection<NPSeries> Get();
        NPSeries Save(NPSeries series);
    }
}
