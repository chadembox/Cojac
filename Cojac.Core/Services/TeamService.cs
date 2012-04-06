using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Repositories;
using Cojac.Core.Models;

namespace Cojac.Core.Services
{
    public class TeamService : Cojac.Core.Services.ITeamService
    {
        ITeamRepository _repository;
        public TeamService(ITeamRepository repository)
        {
            _repository = repository;
        }

        public ICollection<NPTeam> Get()
        {
            return _repository.Get();
        }

        public NPTeam Get(int teamId)
        {
            return _repository.Get(teamId);
        }

        public NPTeam Save(NPTeam team)
        {
            return _repository.Save(team);
        }

        public void Delete(int teamId)
        {
            _repository.Delete(teamId);
        }
    }
}
