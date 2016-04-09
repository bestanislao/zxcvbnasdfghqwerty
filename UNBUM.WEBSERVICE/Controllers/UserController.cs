using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using UNBUM.BL.Interfaces;
using UNBUM.CORE.Accounts;
using UNBUM.WEBSERVICE.Models;


namespace UNBUM.WEBSERVICE.Controllers
{
    public class UserController : ApiController
    {
        IUserProfileBL _userProfileBL;
        public UserController(IUserProfileBL userProfileBL)
        {
            _userProfileBL = userProfileBL;
        }

        //[ValidateAntiForgeryToken]
        [System.Web.Http.HttpGet]
        public UserProfile Login(string userId)
        {
            return _userProfileBL.GetUserProfileByUserId(userId);
        }


        [System.Web.Http.Route("User/Register/")]
        [System.Web.Http.HttpPost]
        public UserProfileVM Register([FromBody] UserProfileVM model)
        {
            try
            {
                var dest = Mapper.Map<UserProfileVM, UserProfile>(model);
                dest.DateCreated = DateTime.Now;
                dest.DateModified = DateTime.Now;
                var result = _userProfileBL.InsertUser(dest);
                var userProfile = Mapper.Map<UserProfile, UserProfileVM>(result);
                userProfile.Email = model.Email;
                userProfile.UserName = model.UserName;
                return userProfile;
            }
            catch (Exception e)
            {

                throw e;
            }

            return null;
        }

        private ActionResult Json(UserProfile result, JsonRequestBehavior allowGet)
        {
            throw new NotImplementedException();
        }
    }
}
