using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class CustomerTransactionVM 
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public int CustomerId { get; set; }
        public int ServiceUserId { get; set; }
        public string CustomerNotes { get; set; }
        public string ServiceNotes { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int RequestServiceId { get; set; }
    }
}