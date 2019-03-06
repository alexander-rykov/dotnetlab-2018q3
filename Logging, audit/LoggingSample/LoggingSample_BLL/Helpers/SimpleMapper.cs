using LoggingSample_BLL.Models;
using LoggingSample_DAL.Entities;

namespace LoggingSample_BLL.Helpers
{
    public static class SimpleMapper
    {
        public static CustomerModel Map(this Customer customer)
        {
            return new CustomerModel
            {
                Id = customer.Id,
                Address = customer.Address,
                City = customer.City,
                Name = customer.Name,
                State = customer.State
            };
        }

        public static Customer Map(this CustomerModel customer)
        {
            return new Customer
            {
                Id = customer.Id,
                Address = customer.Address,
                City = customer.City,
                Name = customer.Name,
                State = customer.State
            };
        }

        public static OrderModel Map(this Order order)
        {
            return new OrderModel
            {
                Id = order.Id,
                Date = order.Date,
                TotalPrice = order.TotalPrice,
                CustomerId = order.CustomerId
            };
        }

        public static Order Map(this OrderModel order)
        {
            return new Order
            {
                Id = order.Id,
                Date = order.Date,
                TotalPrice = order.TotalPrice,
                CustomerId = order.CustomerId
            };
        }
    }
}