using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.BL.Interfaces;
using UNBUM.CORE.Types;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.BL.Transaction
{
    public class CustomerTransactionBL : ICustomerTransactionBL
    {
        ICustomerTransactionWorkflow _customerTransactionWorkflow;
        ICustomerChargesWorkflow _customerChargesWorkflow;
        public CustomerTransactionBL(ICustomerTransactionWorkflow customerTransactionWorkflow
                                    , ICustomerChargesWorkflow customerChargesWorkflow)
        {
            _customerTransactionWorkflow = customerTransactionWorkflow;
            _customerChargesWorkflow = customerChargesWorkflow;
        }

        public int InsertCustomerCharges(CustomerCharges customerCharges)
        {
            return _customerChargesWorkflow.InsertCustomerCharges(customerCharges);
        }

        public int InsertCustomerTransaction(CustomerTransaction customerTransaction)
        {
            return _customerTransactionWorkflow.InsertCustomerTransaction(customerTransaction);
        }

        public CustomerTransaction GetCustomerTransactionByReferenceNumber(string referenceNumber)
        {
            return _customerTransactionWorkflow.GetCustomerTransactionByReferenceNumber(referenceNumber);
        }

        public int UpdateCustomerCharges(CustomerCharges customerCharges)
        {
            return _customerChargesWorkflow.UpdateCustomerCharges(customerCharges);
        }

        public int UpdateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            return _customerTransactionWorkflow.UpdateCustomerTransaction(customerTransaction);
        }
    }
}
