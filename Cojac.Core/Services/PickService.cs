using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Repositories;
using Cojac.Core.Models;

namespace Cojac.Core.Services
{
    public class PickService : Cojac.Core.Services.IPickService
    {
        private IPickRepository _repository;
        
        public PickService(IPickRepository repository)
        {
            _repository = repository;
        }

        public ICollection<NPPick> GetPicksForUser(int userId)
        {
            return _repository.GetPicksForUser(userId);
        }

        public NPPick Save(NPPick pick)
        {
            return _repository.Save(pick);
        }        
    }
}
