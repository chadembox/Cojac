using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public interface ITeamRepository
    {
        ICollection<NPTeam> Get();
        NPTeam Get(int teamId);
        NPTeam Save(NPTeam team);
        void Delete(int teamId);
    }
}
