using System.Collections.Generic;

namespace DAL.Entities
{
    public class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string CCity { get; set; }
        public string CState { get; set; }
        public virtual ICollection<Order> COrders { get; set; }
    }
}
