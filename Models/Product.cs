﻿namespace ecom.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<ProductVariant> Variants { get; set; }
    }
}
