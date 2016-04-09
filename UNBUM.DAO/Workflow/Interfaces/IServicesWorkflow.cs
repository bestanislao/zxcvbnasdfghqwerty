using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.DAO.Workflow.Interfaces
{
    public interface IServicesWorkflow
    {
        List<Services> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng);
        List<Services> GetSearchCategoryByServiceID(int serviceTypeId);
        int InsertRequestService(RequestService requestService);
        List<RequestService> GetRequestService(int serviceId, int status);
        int UpdateRequestServiceStatus(RequestService requestService);
    }
}
