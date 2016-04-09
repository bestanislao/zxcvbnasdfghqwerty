using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;

namespace UNBUM.DAO.Repositories.Interfaces
{
    public interface IUserProfileRepository 
        : IGenericRepository<UserProfile, int>
    {
    }
}
