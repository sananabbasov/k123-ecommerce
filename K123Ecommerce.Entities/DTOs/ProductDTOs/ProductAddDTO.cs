using System;
namespace K123Ecommerce.Entities.DTOs.ProductDTOs
{
	public class ProductAddDTO
	{
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Review { get; set; }
        public string ProductAdjective { get; set; }
        public List<string> PhotoUrl { get; set; }
        public int CategoryId { get; set; }
    }
}

