namespace DAL.Entities
{
    public class OrderItem
    {
        internal int OIOrderId { get; set; }
        internal int OIItemId { get; set; }
        public virtual Order OIOrder { get; set; }
        public virtual Item OIItem { get; set; }
        public int OIQuantity { get; set; }
    }
}
