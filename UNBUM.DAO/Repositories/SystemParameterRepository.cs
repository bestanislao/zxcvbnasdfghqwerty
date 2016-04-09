using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;

namespace UNBUM.DAO.Repositories
{
    public class SystemParameterRepository
           : GenericRepository<SystemParameter, int>, ISystemParameterRepository
    {
        public SystemParameterRepository(IUnitOfWork unitOfWork)
             : base(unitOfWork)
        {
        }
    }
}
