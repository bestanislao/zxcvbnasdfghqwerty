using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;

namespace UNBUM.DAO.Repositories
{
    public class CustomerChargesRepository
         : GenericRepository<CustomerCharges, int>, ICustomerChargesRepository
    {
        public CustomerChargesRepository(IUnitOfWork unitOfWork)
             : base(unitOfWork)
        {
        }
    }
}
