using Microsoft.EntityFrameworkCore;

namespace ecom.Models
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Precision(14, 2)]
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
