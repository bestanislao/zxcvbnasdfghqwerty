using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNBUM.BL.TestBL;

namespace UNBUM.UI.Controllers
{
    public class ServiceController : ApiController
    {
        ITestBL _testBL;
        public ServiceController(ITestBL testBL)
        {
            _testBL = testBL;
        }

        [HttpGet]
        [Route("Service/Get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var product = _testBL.InsertTestType(new CORE.Types.TestType() {

            });

            return Ok(product);
        }
    }
}
