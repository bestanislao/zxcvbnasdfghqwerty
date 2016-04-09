using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    [Serializable]
    public class EntityBase<T>
    {
        public virtual T Id { get; set; }
    }
}
