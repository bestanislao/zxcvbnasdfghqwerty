using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;

namespace UNBUM.DAO.Workflow.Interfaces
{
    public interface IUserProfileWorkflow
    {
        UserProfile InsertUser(UserProfile userProfile);
        UserProfile GetUserProfile(UserProfile userProfile);
        int ModifiedUserProfile(UserProfile userProfile);
        UserProfile GetUserProfileByUserId(string userId);
    }
}
