using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using DAL.Context;
using DAL.Entities;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            ContextKey = "ApplicationData";
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            SeedDatabase(context);
        }

        [Conditional("DEBUG")]
        private void SeedDatabase(AppDbContext context)
        {
            var items = new List<Item>
            {
                new Item
                {
                    IId = 1,
                    IDescription = "56'' Blue Freen",
                    IPrice = 3.5m
                },
                new Item
                {
                    IId = 2,
                    IDescription = "Spline End (Xtra Large)",
                    IPrice = 0.25m
                },
                new Item
                {
                    IId = 3,
                    IDescription = "3'' Red Freen",
                    IPrice = 12m
                }
            };

            context.Items.AddOrUpdate(i => i.IDescription, items.ToArray());


            var customers = new List<Customer>
            {
                new Customer
                {
                    CId = 1,
                    CName = "Foo, Inc",
                    CAddress = "23 Main St., Thorpleburg",
                    CCity = "Thorpleburg",
                    CState = "TX"
                },
                new Customer
                {
                    CId = 2,
                    CName = "Freens R Us",
                    CAddress = "1600 Pennsylvania Avenue",
                    CCity = "Washington",
                    CState = "DC"
                }
            };

            context.Customers.AddOrUpdate(i => i.CName, customers.ToArray());

            var orders = new List<Order>
            {
                new Order
                {
                    OId = 1,
                    ODate = new DateTime(2002, 9, 13),
                    OCustomer = customers[0]
                },
                new Order
                {
                    OId = 2,
                    ODate = new DateTime(2002, 9, 14),
                    OCustomer = customers[1]
                }
            };

            context.Orders.AddOrUpdate(i => i.ODate, orders.ToArray());

            var orderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    OIItem = items[0],
                    OIOrder = orders[0],
                    OIQuantity = 4
                },
                new OrderItem
                {
                    OIItem = items[1],
                    OIOrder = orders[0],
                    OIQuantity = 32
                },
                new OrderItem
                {
                    OIItem = items[2],
                    OIOrder = orders[0],
                    OIQuantity = 5
                },
                new OrderItem
                {
                    OIItem = items[0],
                    OIOrder = orders[1],
                    OIQuantity = 500
                },
                new OrderItem
                {
                    OIItem = items[2],
                    OIOrder = orders[1],
                    OIQuantity = 750
                }
            };

            context.OrderItems.AddOrUpdate(i => i.OIQuantity, orderItems.ToArray());
        }
    }
}
