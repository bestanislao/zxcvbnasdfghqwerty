using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;
using UNBUM.DAO.Repositories.Interfaces;

namespace UNBUM.DAO.Repositories
{
    public class UserProfileRepository
         : GenericRepository<UserProfile, int>, IUserProfileRepository
    {
        public UserProfileRepository(IUnitOfWork unitOfWork)
             : base(unitOfWork)
        {
        }
    }
}
