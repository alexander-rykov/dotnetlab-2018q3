using System.Data.Entity;
using System.Reflection;
using DAL.Entities;

namespace DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("InternationWidgetsContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Migrations.Configuration>(true));
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TODO: setup dbcontext configuration based on "InternationWidgets.mdf" file using EF Fluent API. DO NOT modify any files from "Entities" folder.
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
