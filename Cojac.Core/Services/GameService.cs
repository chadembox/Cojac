using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Repositories;
using Cojac.Core.Models;

namespace Cojac.Core.Services
{
    public class GameService : Cojac.Core.Services.IGameService
    {
        IGameRepository _repository;
        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }

        public ICollection<NPGame> Get()
        {
            return _repository.Get();
        }

        public NPGame Get(int gameId)
        {
            return _repository.Get(gameId);
        }

        public NPGame Save(NPGame game)
        {
            return _repository.Save(game);
        }

        public void Delete(int gameId)
        {
            _repository.Delete(gameId);
        }
    }
}
