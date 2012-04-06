using System;
using System.Collections.Generic;
using Cojac.Core.Models;
namespace Cojac.Core.Services
{
    public interface IGameService
    {
        void Delete(int gameId);
        ICollection<NPGame> Get();
        NPGame Get(int gameId);
        NPGame Save(NPGame game);
    }
}
