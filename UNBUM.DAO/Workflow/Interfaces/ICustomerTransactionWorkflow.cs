using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.DAO.Workflow.Interfaces
{
    public interface ICustomerTransactionWorkflow
    {
        int InsertCustomerTransaction(CustomerTransaction customerTransaction);
        int UpdateCustomerTransaction(CustomerTransaction customerTransaction);
        CustomerTransaction GetCustomerTransactionByReferenceNumber(string referenceNumber);

    }
}
