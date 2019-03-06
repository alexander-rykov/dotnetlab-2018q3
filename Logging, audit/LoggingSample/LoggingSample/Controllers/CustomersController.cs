using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;
using LoggingSample_BLL.Helpers;
using LoggingSample_BLL.Models;
using LoggingSample_DAL.Context;

namespace LoggingSample.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly AppDbContext _context = new AppDbContext();

        [Route("")]
        public async Task<IHttpActionResult> Get()
        {
            var customers = (await _context.Customers.ToListAsync()).Select(item => item.Map()).Select(InitCustomer);

            return Ok(customers);
        }

        [Route("{customerId}", Name = "Customer")]
        public async Task<IHttpActionResult> Get(int customerId)
        {
            var customer = (await _context.Customers.SingleOrDefaultAsync(item => item.Id == customerId)).Map();

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(InitCustomer(customer));
        }


        private object InitCustomer(CustomerModel model)
        {
            return new
            {
                _self = new UrlHelper(Request).Link("Customer", new {customerId = model.Id}),
                orders = new UrlHelper(Request).Link("Orders", new { customerId = model.Id }),
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