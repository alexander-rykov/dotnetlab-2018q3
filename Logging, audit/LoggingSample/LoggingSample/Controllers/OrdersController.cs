using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Routing;
using LoggingSample_BLL.Helpers;
using LoggingSample_BLL.Models;
using LoggingSample_DAL.Context;
using LoggingSample_DAL.Entities;

namespace LoggingSample.Controllers
{
    [RoutePrefix("api")]
    public class OrdersController : ApiController
    {
        private readonly AppDbContext _context = new AppDbContext();

        [Route("customers/{customerId}/orders", Name = "Orders")]
        public async Task<IHttpActionResult> Get(int customerId)
        {
            var customers = (await _context.Orders.Where(item => item.CustomerId == customerId).ToListAsync()).Select(item => item.Map()).Select(InitOrder);

            return Ok(customers);
        }

        [Route("customers/{customerId}/orders/{orderId}", Name = "Order")]
        public async Task<IHttpActionResult> Get(int customerId, int orderId)
        {
            var customer = (await _context.Orders.SingleOrDefaultAsync(item => item.Id == orderId && item.CustomerId == customerId)).Map();

            if (customer == null) {
                return NotFound();
            }

            return Ok(InitOrder(customer));
        }

        private object InitOrder(OrderModel model)
        {
            return new
            {
                _self = new UrlHelper(Request).Link("Order", new {customerId = model.CustomerId, orderId = model.Id}),
                customer = new UrlHelper(Request).Link("Customer", new {customerId = model.CustomerId}),
                data = model
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}