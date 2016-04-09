using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using System.Web;
using System.Web.Http;
using UNBUM.WEBSERVICE.Controllers;
using Unity.WebApi;

namespace UNBUM.WEBSERVICE
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
			var container = new UnityContainer();
            container = STARTUP.StartupInstaller.RegisterStartupInstaller();
            container.RegisterType<AccountController>(
    new InjectionFactory(c => new AccountController()));
            container.RegisterType<ApplicationSignInManager>();
            config.DependencyResolver = new UnityDependencyResolver(container);
            container.RegisterType<IAuthenticationManager>(
    new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}