using System.Collections.Generic;
using LoggingSample_DAL.Entities;

namespace LoggingSample_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoggingSample_DAL.Context.AppDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Foo, Inc",
                    Address = "23 Main St., Thorpleburg",
                    City = "Thorpleburg",
                    State = "TX"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Freens R Us",
                    Address = "1600 Pennsylvania Avenue",
                    City = "Thorpleburg",
                    State = "DC"
                }
            };

            context.Customers.AddOrUpdate(customer => customer.Name, customers.ToArray());
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order
                {
                    Date = new DateTime(2002, 9, 13),
                    TotalPrice = 82,
                    CustomerId = 1
                },
                new Order
                {
                    Date = new DateTime(2002, 9, 14),
                    TotalPrice = 10750,
                    CustomerId = 2
                }
            };

            context.Orders.AddOrUpdate(order => order.Date, orders.ToArray());
            context.SaveChanges();
        }
    }
}
