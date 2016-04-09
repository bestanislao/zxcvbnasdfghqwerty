using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNBUM.CORE.Accounts;
using UNBUM.CORE.Initializer;
using UNBUM.CORE.Types;

namespace UNBUM.CORE.Context
{
    public class UNBUMDbContext : DbContext
    {
        public object CustomerTransaction { get; internal set; }

        public UNBUMDbContext() : base("UNBUMDbContext")
        {
            Database.SetInitializer<UNBUMDbContext>(new DBInitializer());
        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //one-to-many 
            modelBuilder.Entity<CustomerTransaction>()
                   .HasMany<CustomerCharges>(s => s.CustomerCharges);

            modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<ApplicationUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().HasKey(x => x.RoleId).ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().HasKey(x => x.UserId).ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile");
            modelBuilder.Entity<Services>().ToTable("Services");
            modelBuilder.Entity<RequestService>().ToTable("RequestService");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            Database.SetInitializer(new DBInitializer());
        }

        public static UNBUMDbContext Create()
        {
            return new UNBUMDbContext();
        }

    }
}
