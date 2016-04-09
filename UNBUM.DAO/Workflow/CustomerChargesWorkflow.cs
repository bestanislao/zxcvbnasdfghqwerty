using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Translator;
using UNBUM.CORE.Types;
using UNBUM.DAO.Repositories.Interfaces;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.DAO.Workflow
{
    public class CustomerChargesWorkflow : ICustomerChargesWorkflow
    {
        ICustomerChargesRepository _customerChargesRepository;
        IUnitOfWork _unitOfWork;
        public CustomerChargesWorkflow(ICustomerChargesRepository customerChargesRepository
                                          , IUnitOfWork unitOfWork)
        {
            _customerChargesRepository = customerChargesRepository;
            _unitOfWork = unitOfWork;
        }

        public int InsertCustomerCharges(CustomerCharges customerCharges)
        {            
            _customerChargesRepository.Insert(customerCharges);
            _unitOfWork.Save();
            return customerCharges.Id;
        }

        public int UpdateCustomerCharges(CustomerCharges customerCharges)
        {
            CustomerCharges forUpdate = _customerChargesRepository.GetById(customerCharges.Id);            
            _customerChargesRepository.Update(CustomerChargesTranslator.UpdateCustomerChargesTranslator(customerCharges, forUpdate));
            _unitOfWork.Save();
            return customerCharges.Id;
        }
    }
}
