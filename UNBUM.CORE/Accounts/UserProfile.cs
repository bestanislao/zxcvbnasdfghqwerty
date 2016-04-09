using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Accounts
{
    public class UserProfile : EntityBase<int>
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string RoleId { get; set; }
        public string TinNumber { get; set; }
        public string IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string Ratings { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }

    }
}
