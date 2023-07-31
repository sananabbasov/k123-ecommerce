using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Core.Entities.Concrete
{
	public class Role : IEntity
	{
		public int Id { get; set; }
		public string RoleName { get; set; }
	}
}

