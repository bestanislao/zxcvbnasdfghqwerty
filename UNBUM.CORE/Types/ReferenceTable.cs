using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class ReferenceTable : EntityBase<int>
    {
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public string GroupName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}
