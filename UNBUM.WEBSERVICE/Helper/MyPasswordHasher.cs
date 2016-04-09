using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;

namespace UNBUM.WEBSERVICE.Helper
{
    public class MyPasswordHasher : PasswordHasher
    {
        public FormsAuthPasswordFormat FormsAuthPasswordFormat { get; set; }

        public MyPasswordHasher(FormsAuthPasswordFormat format)
        {
            FormsAuthPasswordFormat = format;
        }

        public override string HashPassword(string password)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, FormsAuthPasswordFormat.ToString());
        }

        public override PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            var testHash = FormsAuthentication.HashPasswordForStoringInConfigFile(providedPassword, FormsAuthPasswordFormat.ToString());
            return hashedPassword.Equals(testHash) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        }
    }
}