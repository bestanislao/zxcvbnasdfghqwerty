using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;
using UNBUM.CORE.Context;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Initializer
{
    public class DBInitializer : CreateDatabaseIfNotExists<UNBUMDbContext>
    {
        protected override void Seed(UNBUMDbContext context)
        {
            #region ReferenceTable
            context.Set<ReferenceTable>().Add(new ReferenceTable()
            {
                FieldId = 1,
                FieldValue = "Laundry",
                GroupName = "ServiceType",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<ReferenceTable>().Add(new ReferenceTable()
            {
                FieldId = 2,
                FieldValue = "Massage",
                GroupName = "ServiceType",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<ReferenceTable>().Add(new ReferenceTable()
            {
                FieldId = 3,
                FieldValue = "Cleaning",
                GroupName = "ServiceType",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<ReferenceTable>().Add(new ReferenceTable()
            {
                FieldId = 4,
                FieldValue = "Errands",
                GroupName = "ServiceType",
                IsActive = true,
                DateModified = DateTime.Now,
            });
            #endregion


            #region Roles
            context.Set<Roles>().Add(new Roles()
            {
                RoleId = 1,
                RoleName = "Admin",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<Roles>().Add(new Roles()
            {
                RoleId = 2,
                RoleName = "Customer",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<Roles>().Add(new Roles()
            {
                RoleId = 3,
                RoleName = "Merchant",
                IsActive = true,
                DateModified = DateTime.Now,
            });

            context.Set<Roles>().Add(new Roles()
            {
                RoleId = 4,
                RoleName = "Errand",
                IsActive = true,
                DateModified = DateTime.Now,
            });
            #endregion
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
