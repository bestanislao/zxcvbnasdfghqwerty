using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;
using UNBUM.DAO.Repositories.Interfaces;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.DAO.Workflow
{
    public class UserProfileWorkflow : IUserProfileWorkflow
    {
        IUserProfileRepository _userProfileRepository;
        IUnitOfWork _unitOfWork;
        public UserProfileWorkflow(IUnitOfWork unitOfWork
                                   ,IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
            _unitOfWork = unitOfWork;
        }
        public UserProfile InsertUser(UserProfile userProfile)
        {
            try
            {
                _userProfileRepository.Insert(userProfile);
                _unitOfWork.Save();
                return _userProfileRepository.Find(x => x.Id == userProfile.Id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }  
        }

        public UserProfile GetUserProfile(UserProfile userProfile)
        {
            return _userProfileRepository.Find(x => x.Id == userProfile.Id).FirstOrDefault();
        }

        public int ModifiedUserProfile(UserProfile userProfile)
        {
            _userProfileRepository.Update(userProfile);
            return userProfile.Id;
        }

        public UserProfile GetUserProfileByUserId(string userId)
        {
            return _userProfileRepository.Find(x => x.UserId == userId).First();
        }
    }
}
