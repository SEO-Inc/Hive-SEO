using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class HiveContext : DbContext
    {
        public HiveContext()
            : base("DefaultConnection")
        {
            //only return the values we request not related data
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            //code first migrations intializer
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<HiveContext, HiveMigrationsConfiguration>()
                );


        }

        public DbSet<Domain> Domains { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}