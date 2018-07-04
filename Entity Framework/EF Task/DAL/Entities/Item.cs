using System.Collections.Generic;

namespace DAL.Entities
{
    public class Item
    {
        public int IId { get; set; }
        public string IDescription { get; set; }
        public decimal IPrice { get; set; }
        public virtual ICollection<OrderItem> IOrderItems { get; set; }
    }
}
