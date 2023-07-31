using System;
using K123Ecommerce.Core.Entities.Abstract;

namespace K123Ecommerce.Core.Entities.Concrete
{
	public class User : IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public bool EmailConfirmed { get; set; }
	}
}
