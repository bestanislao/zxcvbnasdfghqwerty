using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Context;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Initializer
{
    public class DBInitializer : CreateDatabaseIfNotExists<UNBUMDbContext>
    {
        protected override void Seed(UNBUMDbContext context)
        {
            //List<CustomerCharges> c = new List<CustomerCharges>();
            //c.Add(new CustomerCharges() {
            //    DateModified = DateTime.Now,
            //    Amount = 11,

            //});
            //context.Set<CustomerTransaction>().Add(new CustomerTransaction()
            //{
            //    CustomerId = 1,
            //    CreatedBy = 2,
            //    DateCreated = DateTime.Now,
            //    DateModified = DateTime.Now,
            //    CustomerCharges = c,
            //});
            context.Set<Services>().Add(new Services()
            {
                UserId = 1,
                ServiceType = 1,
                ServiceName = "Parlor",
                Address = "4483 F calatagan",
                LocationLat = "1",
                LocationLng = "2",
                PriceRange = "1212-12121",
                Description = "Description test",
                IsActive = true,
                DateCreated = DateTime.Now,
                CreatedBy = 1,
                DateModified = DateTime.Now,
                ModifiedBy = 2
            });

            context.Set<Services>().Add(new Services()
            {
                UserId = 1,
                ServiceType = 1,
                ServiceName = "Parlor",
                Address = "4484 F calatagan",
                LocationLat = "3",
                LocationLng = "4",
                PriceRange = "1212-12121",
                Description = "Description test",
                IsActive = true,
                DateCreated = DateTime.Now,
                CreatedBy = 1,
                DateModified = DateTime.Now,
                ModifiedBy = 2
            });

            context.Set<Services>().Add(new Services()
            {
                UserId = 1,
                ServiceType = 2,
                ServiceName = "Parlor",
                Address = "4485 F calatagan",
                LocationLat = "5",
                LocationLng = "6",
                PriceRange = "1212-12121",
                Description = "Description test",
                IsActive = true,
                DateCreated = DateTime.Now,
                CreatedBy = 1,
                DateModified = DateTime.Now,
                ModifiedBy = 2
            });
            base.Seed(context);
        }
    }
}
