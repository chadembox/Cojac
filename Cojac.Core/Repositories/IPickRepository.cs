using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public interface IPickRepository 
    {
        ICollection<NPPick> GetPicksForUser(int userId);
        ICollection<NPPick> GetPicksForSeries(int userId, int seriesId);
        NPPick Save(NPPick entity);
    }
}
