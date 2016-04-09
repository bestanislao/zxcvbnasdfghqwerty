using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.BL.ServicesBL
{
    public interface IServicesBL
    {
        List<Services> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng);
        List<Services> GetSearchCategoryByServiceID(int serviceTypeId);
        Services GetSearchServiceByServiceTypeIdAndAddress(int serviceId, string address);
        int InsertRequestService(RequestService requestService);
        List<RequestService> GetRequestService(int serviceId, int status);
        int UpdateRequestServiceStatus(RequestService requestService);
    }
}
