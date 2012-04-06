using System;
using System.Collections.Generic;
using Cojac.Core.Models;
namespace Cojac.Core.Services
{
    public interface ITeamService
    {
        void Delete(int id);
        ICollection<NPTeam> Get();
        NPTeam Get(int id);
        NPTeam Save(NPTeam team);
    }
}
