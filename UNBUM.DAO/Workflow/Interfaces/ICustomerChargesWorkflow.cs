using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.DAO.Workflow.Interfaces
{
    public interface  ICustomerChargesWorkflow
    {
        int InsertCustomerCharges(CustomerCharges customerCharges);
        int UpdateCustomerCharges(CustomerCharges customerCharges);
    }
}
