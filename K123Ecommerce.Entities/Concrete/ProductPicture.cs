using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Entities.Concrete
{
	public class ProductPicture : BaseEntity, IEntity
	{
		public string PhotoUrl { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}

