namespace ecom.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public List<CartItem> Items { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
