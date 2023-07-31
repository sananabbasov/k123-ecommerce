using System;
using K123Ecommerce.Core.Utilities.Security.Hashing;

namespace K123Ecommerce.NUnitTest
{
	[TestFixture]
	public class PasswordTests
	{


		[Test]
		public void CheckUserPassword()
		{
            byte[] passwordHash, passwordSalt;
            PasswordHashing.HashPassword("12345",out passwordHash,out passwordSalt);

			var data = PasswordHashing.VerifyPassword("12345", passwordHash, passwordSalt);
			Assert.True(data);
        }

        [Test]
        public void CheckUserWrongPassword()
        {
            byte[] passwordHash, passwordSalt;
            PasswordHashing.HashPassword("12345", out passwordHash, out passwordSalt);

            var data = PasswordHashing.VerifyPassword("123457", passwordHash, passwordSalt);
            Assert.False(data);
        }

    }
}

