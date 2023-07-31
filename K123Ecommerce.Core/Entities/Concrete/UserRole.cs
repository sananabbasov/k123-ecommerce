using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Core.Entities.Concrete
{
	public class UserRole : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}

