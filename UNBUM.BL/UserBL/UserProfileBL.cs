using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.BL.Interfaces;
using UNBUM.CORE.Accounts;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.BL.UserBusinessLayer
{
    public class UserProfileBL : IUserProfileBL
    {
        IUserProfileWorkflow _userProfileWorkflow;
        public UserProfileBL(IUserProfileWorkflow userProfileWorkflow)
        {
            _userProfileWorkflow = userProfileWorkflow;
        }

        public UserProfile GetUserProfile(UserProfile userProfile)
        {
            return _userProfileWorkflow.GetUserProfile(userProfile);
        }

        public UserProfile GetUserProfileByUserId(string userId)
        {
            return _userProfileWorkflow.GetUserProfileByUserId(userId);
        }

        public UserProfile InsertUser(UserProfile userProfile)
        {
            return _userProfileWorkflow.InsertUser(userProfile);
        }

        public int ModifiedUserProfile(UserProfile userProfile)
        {
            return _userProfileWorkflow.ModifiedUserProfile(userProfile);
        }
    }
}
