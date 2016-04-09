using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNBUM.BL.Interfaces;
using UNBUM.CORE.Types;
using UNBUM.WEBSERVICE.Models;

namespace UNBUM.WEBSERVICE.Controllers
{
    public class CustomerTransactionController : ApiController
    {
        ICustomerTransactionBL _customerTransactionBL;
        public CustomerTransactionController(ICustomerTransactionBL customerTransactionBL)
        {
            _customerTransactionBL = customerTransactionBL;
        }   

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("CustomerTransaction/InsertCustomerTransaction/")]
        public int InsertCustomerTransaction([FromUri]CustomerTransactionVM customerTransactionVM)
        {

            var request = Mapper.Map<CustomerTransactionVM, CustomerTransaction>(customerTransactionVM);
            request.DateModified = DateTime.Now;
            request.DateCreated = DateTime.Now;
            return _customerTransactionBL.InsertCustomerTransaction(request);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("CustomerTransaction/InsertCustomerCharges/")]
        public int InsertCustomerCharges([FromUri]CustomerChargesVM customerChargesVM)
        {
            var request = Mapper.Map<CustomerChargesVM, CustomerCharges>(customerChargesVM);
            request.DateModified = DateTime.Now;
            return _customerTransactionBL.InsertCustomerCharges(request);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("CustomerTransaction/UpdateCustomerCharges/")]
        public int UpdateCustomerCharges([FromUri]CustomerChargesVM customerChargesVM)
        {
            var request = Mapper.Map<CustomerChargesVM, CustomerCharges>(customerChargesVM);
            request.DateModified = DateTime.Now;
            return _customerTransactionBL.UpdateCustomerCharges(request);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("CustomerTransaction/GetCustomerTransactionByReferenceNumber/")]
        public HttpResponseMessage GetCustomerTransactionByReferenceNumber(string referenceNumber)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _customerTransactionBL.GetCustomerTransactionByReferenceNumber(referenceNumber));
            //return _customerTransactionBL.GetCustomerTransactionByReferenceNumber(referenceNumber);
            //return _customerTransactionBL.GetCustomerTransactionByReferenceNumber(referenceNumber);
        }


    }
}
