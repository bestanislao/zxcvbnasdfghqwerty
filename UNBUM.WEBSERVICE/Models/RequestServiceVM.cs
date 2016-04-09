using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class RequestServiceVM
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public DateTime DateModified { get; set; }  //optional upon request
        public int ModifiedBy { get; set; } //optional upon request
    }
}