using System;
using System.Collections.Generic;
using Cojac.Core.Models;
namespace Cojac.Core.Services
{
    public interface IPickService
    {
        ICollection<NPPick> GetPicksForUser(int userId);
        NPPick Save(NPPick pick);
    }
}
