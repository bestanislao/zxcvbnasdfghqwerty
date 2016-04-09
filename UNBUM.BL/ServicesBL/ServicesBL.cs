using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.BL.ServicesBL
{
    public class ServicesBL : IServicesBL
    {
        IServicesWorkflow _servicesWorkflow;
        public ServicesBL(IServicesWorkflow servicesWorkflow)
        {
            _servicesWorkflow = servicesWorkflow;
        }

        public List<RequestService> GetRequestService(int serviceId, int status)
        {
            return _servicesWorkflow.GetRequestService(serviceId, status);
        }

        public List<Services> GetSearchCategoryByServiceID(int serviceTypeId)
        {
            return _servicesWorkflow.GetSearchCategoryByServiceID(serviceTypeId);
        }

        public List<Services> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng)
        {
            return _servicesWorkflow.GetSearchCategoryByServiceIDLatLongLang(serviceTypeId, lat, lng);
        }

        public Services GetSearchServiceByServiceTypeIdAndAddress(int serviceId, string address)
        {
            throw new NotImplementedException();
        }

        public int InsertRequestService(RequestService requestService)
        {
            return _servicesWorkflow.InsertRequestService(requestService);
        }

        public int UpdateRequestServiceStatus(RequestService requestService)
        {
            return _servicesWorkflow.UpdateRequestServiceStatus(requestService);
        }
    }
}
