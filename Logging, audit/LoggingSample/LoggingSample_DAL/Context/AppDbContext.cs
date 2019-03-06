using System.Data.Entity;
using LoggingSample_DAL.Configuration;
using LoggingSample_DAL.Entities;

namespace LoggingSample_DAL.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("LoggingSampleAppData")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
        }
    }
}