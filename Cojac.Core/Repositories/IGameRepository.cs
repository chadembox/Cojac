using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public interface IGameRepository
    {
        ICollection<NPGame> Get();
        NPGame Get(int gameId);
        NPGame Save(NPGame game);
        void Delete(int gameId);
    }
}
