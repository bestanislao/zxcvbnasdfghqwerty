using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class Services : EntityBase<int>
    {
        public int UserId { get; set; }
        public int ServiceType { get; set; }
        public string ServiceName { get; set; }
        public string Address { get; set; }
        public string LocationLat { get; set; }
        public string LocationLng { get; set; }
        public string PriceRange { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}
