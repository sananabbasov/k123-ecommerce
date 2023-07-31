using System;
namespace K123Ecommerce.Core.Utilities.Results.Abstract
{
	public interface IResult
	{
		public bool Success { get;  }
		public string Message { get;  }
	}
}

