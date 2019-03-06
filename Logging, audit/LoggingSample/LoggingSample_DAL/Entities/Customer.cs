using System.Collections.Generic;

namespace LoggingSample_DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}