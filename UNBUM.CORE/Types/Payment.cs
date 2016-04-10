using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class Payment : EntityBase<int>
    {
        public int CustomerTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Change { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }
    }
}
