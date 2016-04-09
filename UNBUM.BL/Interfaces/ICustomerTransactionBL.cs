using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.BL.Interfaces
{
    public interface ICustomerTransactionBL
    {
        int InsertCustomerTransaction(CustomerTransaction customerTransaction);
        int InsertCustomerCharges(CustomerCharges customerCharges);
        int UpdateCustomerCharges(CustomerCharges customerCharges);
        int UpdateCustomerTransaction(CustomerTransaction customerTransaction);
        CustomerTransaction GetCustomerTransactionByReferenceNumber(string referenceNumber);
    }
}
