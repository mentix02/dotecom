using System.ComponentModel.DataAnnotations;

namespace ecom.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Country { get; set; }
        [StringLength(60)]
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [StringLength(10)]
        [Required]
        public string PostalCode { get; set; }
    }
}
