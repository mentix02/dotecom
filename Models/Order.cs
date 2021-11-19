namespace ecom.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public DateTime Timestamp { get; set; }
        public string ApplicationUserId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
