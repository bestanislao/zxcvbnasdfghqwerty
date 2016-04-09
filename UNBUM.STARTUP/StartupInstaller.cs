using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.BL.Interfaces;
using UNBUM.BL.ServicesBL;
using UNBUM.BL.Transaction;
using UNBUM.BL.UserBusinessLayer;
using UNBUM.DAO;
using UNBUM.DAO.Repositories;
using UNBUM.DAO.Repositories.Interfaces;
using UNBUM.DAO.Workflow;
using UNBUM.DAO.Workflow.Interfaces;

namespace UNBUM.STARTUP
{
    public class StartupInstaller
    {
        public static UnityContainer RegisterStartupInstaller()
        {
            var container = new UnityContainer();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager());

            #region Repository
            container.RegisterType<IUserProfileRepository, UserProfileRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IServicesRepository, ServicesRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerTransactionRepository, CustomerTransactionRepository>(new ContainerControlledLifetimeManager());

            container.RegisterType<IAuditTrailRepository, AuditTrailRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerChargesRepository, CustomerChargesRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerTransactionRepository, CustomerTransactionRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<ISystemParameterRepository, SystemParameterRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRequestServiceRepository, RequestServiceRepository>(new ContainerControlledLifetimeManager());
        
            
            #endregion End Repository

            #region Workflow
            container.RegisterType<IUserProfileWorkflow, UserProfileWorkflow>(new ContainerControlledLifetimeManager());
            container.RegisterType<IServicesWorkflow, ServicesWorkflow>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerTransactionWorkflow, CustomerTransactionWorkflow>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerChargesWorkflow, CustomerChargesWorkflow>(new ContainerControlledLifetimeManager());
            #endregion End Workflow

            #region BusinessLayer
            container.RegisterType<IUserProfileBL, UserProfileBL>(new ContainerControlledLifetimeManager());
            container.RegisterType<IServicesBL, ServicesBL>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICustomerTransactionBL, CustomerTransactionBL>(new ContainerControlledLifetimeManager());
            #endregion End BusinessLayer
            return container;
        }
    }
}
