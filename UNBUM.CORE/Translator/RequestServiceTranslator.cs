using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Translator
{
    public class RequestServiceTranslator
    {
        public static RequestService UpdateRequestServiceStatusTranslator(RequestService update, RequestService fromDB)
        {
            RequestService forUpdate = new RequestService();
            forUpdate.Id = fromDB.Id;
            forUpdate.DateCreated = fromDB.DateCreated;
            forUpdate.ServiceId = fromDB.ServiceId;
            forUpdate.Customer = fromDB.Customer;
            forUpdate.Address = fromDB.Address;
            forUpdate.Status = update.Status;
            forUpdate.DateModified = DateTime.Now;
            forUpdate.ModifiedBy = update.ModifiedBy;
            return forUpdate;          
        }
    }
}
