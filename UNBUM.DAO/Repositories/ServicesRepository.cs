using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;

namespace UNBUM.DAO.Repositories
{
    public class ServicesRepository 
        : GenericRepository<Services, int>, IServicesRepository
    {
        public ServicesRepository(IUnitOfWork unitOfWork)
             : base(unitOfWork)
        {
        }
    }
}
