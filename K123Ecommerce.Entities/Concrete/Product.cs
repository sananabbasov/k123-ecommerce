using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Entities.Concrete
{
	public class Product : BaseEntity, IEntity
	{
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int Discount { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public decimal Raiting { get; set; }
		public string ProductAdjective { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public List<ProductPicture> ProductPictures { get; set; }
	}
}

