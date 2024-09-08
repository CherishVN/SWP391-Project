namespace EventFlowerExchange.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
        public int SellerId { get; set; }
        public User Seller { get; set; }
    }
}
