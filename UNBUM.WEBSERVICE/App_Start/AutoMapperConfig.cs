using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNBUM.CORE.Accounts;
using UNBUM.CORE.Types;
using UNBUM.WEBSERVICE.Models;

namespace UNBUM.WEBSERVICE.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMapper()
        {
            //cfg.CreateMap<Source, Destination>();
            Mapper.Initialize(cfg => {
                cfg.CreateMap<UserProfileVM, UserProfile>();
                cfg.CreateMap<UserProfile, UserProfileVM>();
                cfg.CreateMap<UserProfileVM, ApplicationUser>();
                cfg.CreateMap<Services, ServicesVM>();
                cfg.CreateMap<RequestServiceVM, RequestService>();
                cfg.CreateMap<RequestService, RequestServiceVM>();
                cfg.CreateMap<CustomerTransactionVM, CustomerTransaction>();
                cfg.CreateMap<CustomerTransaction, CustomerTransactionVM>();
                cfg.CreateMap<CustomerChargesVM, CustomerCharges>();
                cfg.CreateMap<CustomerCharges, CustomerChargesVM>();
            });
        }
    }
}