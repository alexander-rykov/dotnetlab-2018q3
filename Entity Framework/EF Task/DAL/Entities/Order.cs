using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Order
    {
        public int OId { get; set; }
        public DateTime ODate { get; set; }
        public virtual Customer OCustomer { get; set; }
        public virtual ICollection<OrderItem> OOrderItems { get; set; }
    }
}