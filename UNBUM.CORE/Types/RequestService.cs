using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class RequestService : EntityBase<int>
    {
        public int ServiceId { get; set; }
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}
