using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class CustomerChargesVM
    {
        public int Id { get; set; }
        public int CustomerTransactionId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ItemName { get; set; }
        public string ItemCount { get; set; }
        public string ItemDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Change { get; set; }
        public string PromoCode { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string ComputedDistance { get; set; }
        public string PictureSelfieFilePath { get; set; }
        public string Remarks { get; set; }
        public DateTime DateModified { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
    }
}