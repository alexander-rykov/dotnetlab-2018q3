using System.Data.Entity.ModelConfiguration;
using LoggingSample_DAL.Entities;

namespace LoggingSample_DAL.Configuration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            this.ToTable("order").HasKey(item => item.Id);
            this.Property(order => order.Date).HasColumnName("date");
            this.Property(order => order.TotalPrice).HasColumnName("total_price");
            this.Property(order => order.CustomerId).HasColumnName("customer_id");
        }
    }
}