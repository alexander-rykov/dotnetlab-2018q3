using System.Data.Entity.ModelConfiguration;
using LoggingSample_DAL.Entities;

namespace LoggingSample_DAL.Configuration
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            this.ToTable("customer").HasKey(item => item.Id);
            this.Property(customer => customer.Name).HasColumnName("name");
            this.Property(customer => customer.Address).HasColumnName("address");
            this.Property(customer => customer.City).HasColumnName("city");
            this.Property(customer => customer.State).HasColumnName("state");
            this.HasMany(customer => customer.Orders).WithRequired(order => order.Customer)
                .HasForeignKey(order => order.CustomerId);
        }
    }
}