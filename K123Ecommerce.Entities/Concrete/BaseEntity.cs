using System;
namespace K123Ecommerce.Entities.Concrete
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsActive { get; set; }
	}
}

