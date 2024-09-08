namespace EventFlowerExchange.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public User Buyer { get; set; }
        public int FlowerId { get; set; }
        public Flower Flower { get; set; }
        public string Status { get; set; } 
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
