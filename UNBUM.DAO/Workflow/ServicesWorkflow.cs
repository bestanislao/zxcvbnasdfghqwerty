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
    public class ServicesWorkflow : IServicesWorkflow
    {
        IServicesRepository _servicesRepository;
        IRequestServiceRepository _requestServiceRepository;
        IUnitOfWork _unitOfWork;
        public ServicesWorkflow(IServicesRepository servicesRepository
                                , IRequestServiceRepository requestServiceRepository
                                , IUnitOfWork unitOfWork)
        {
            _servicesRepository = servicesRepository;
            _requestServiceRepository = requestServiceRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Services> GetSearchCategoryByServiceID(int serviceTypeId)
        {
            return _servicesRepository.Get(x => x.ServiceType == serviceTypeId);
        }

        public List<Services> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng)
        {
            return _servicesRepository.Get(x => x.ServiceType == serviceTypeId & x.LocationLat == lat & x.LocationLng == lng);
        }

        public int InsertRequestService(RequestService requestService)
        {
            _requestServiceRepository.Insert(requestService);
            _unitOfWork.Save();
            return requestService.Id;
        }

        public List<RequestService> GetRequestService(int serviceId, int status)
        {
            return _requestServiceRepository.Get(x => x.ServiceId == serviceId && x.Status == status);
        }

        public int UpdateRequestServiceStatus(RequestService requestService)
        {
            RequestService forUpdate = _requestServiceRepository.GetById(requestService.Id);           
            _requestServiceRepository.Update(RequestServiceTranslator.UpdateRequestServiceStatusTranslator(requestService, forUpdate));
            _unitOfWork.Save();
            return requestService.Id;
        }

       
    }
}
