using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;

namespace UNBUM.BL.Interfaces
{
    public interface IUserProfileBL
    {
        UserProfile InsertUser(UserProfile userProfile);
        UserProfile GetUserProfile(UserProfile userProfile);
        int ModifiedUserProfile(UserProfile userProfile);
        UserProfile GetUserProfileByUserId(string userId);

    }
}
