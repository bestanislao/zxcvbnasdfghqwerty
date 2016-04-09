using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.DAO.Workflow
{
    public class CustomerTransactionWorkflow : ICustomerTransactionWorkflow
    {
        ICustomerTransactionRepository _customerTransactionRepository;
        IUnitOfWork _unitOfWork;
        public CustomerTransactionWorkflow(ICustomerTransactionRepository customerTransactionRepository
                                          ,IUnitOfWork unitOfWork)
        {
            _customerTransactionRepository = customerTransactionRepository;
            _unitOfWork = unitOfWork;
        }

        public CustomerTransaction GetCustomerTransactionByReferenceNumber(string referenceNumber)
        {
            return _customerTransactionRepository.Find(x => x.ReferenceNumber == referenceNumber, y=>y.CustomerCharges).FirstOrDefault();
        }

        public int InsertCustomerTransaction(CustomerTransaction customerTransaction)
        {
            _customerTransactionRepository.Insert(customerTransaction);
            _unitOfWork.Save();
            return customerTransaction.Id;
        }

        public int UpdateCustomerTransaction(CustomerTransaction customerTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
