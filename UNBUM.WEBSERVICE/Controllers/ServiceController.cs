using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNBUM.BL.ServicesBL;
using UNBUM.CORE.Types;
using UNBUM.WEBSERVICE.Models;

namespace UNBUM.WEBSERVICE.Controllers
{
    public class ServiceController : ApiController
    {
        IServicesBL _servicesBL;
        public ServiceController(IServicesBL servicesBL)
        {
            _servicesBL = servicesBL;
        }
        
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetSearchCategoryByServiceIDLatLongLang/")]
        public List<ServicesVM> GetSearchCategoryByServiceIDLatLongLang(int serviceTypeId, string lat, string lng)
        {
            return Mapper.Map<List<Services>, List<ServicesVM>>(_servicesBL.GetSearchCategoryByServiceIDLatLongLang(serviceTypeId, lat, lng));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetSearchCategoryByServiceID/")]
        public List<ServicesVM> GetSearchCategoryByServiceID(int serviceTypeId)
        {
            return Mapper.Map<List<Services>, List<ServicesVM>>(_servicesBL.GetSearchCategoryByServiceID(serviceTypeId));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/RequestService/")]
        public int RequestService([FromUri]RequestServiceVM requestServiceVM)
        {
            requestServiceVM.DateCreated = DateTime.Now;
            requestServiceVM.DateModified = DateTime.Now;
            var request = Mapper.Map<RequestServiceVM, RequestService>(requestServiceVM);
            return _servicesBL.InsertRequestService(request);
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/GetRequestService/")]
        public List<RequestServiceVM> GetRequestService(int serviceId, int status)
        {
            return Mapper.Map<List<RequestService>, List<RequestServiceVM>>(_servicesBL.GetRequestService(serviceId, status));
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Service/UpdateRequestServiceStatus/")]
        public int UpdateRequestServiceStatus([FromUri]RequestServiceVM requestServiceVM)
        {
            return _servicesBL.UpdateRequestServiceStatus(Mapper.Map<RequestServiceVM, RequestService>(requestServiceVM));
        }




       

     
        

        [Route("Service/Get/{id}")]
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }
    }
}
