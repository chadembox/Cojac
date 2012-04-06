using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cojac.Core.Models;

namespace Cojac.Core.Repositories
{
    public interface IUserRepository
    {
        JUser ValidUser(string username, string password);     
    }
}
