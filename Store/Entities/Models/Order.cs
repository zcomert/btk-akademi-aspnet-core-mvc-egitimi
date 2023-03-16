namespace Entities.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public String Name { get; set; }
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String Line3 { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public bool GiftWrap { get; set; }
        public bool Shipped { get; set; }
        public DateTime OrderedAt { get; set; }
    }
}