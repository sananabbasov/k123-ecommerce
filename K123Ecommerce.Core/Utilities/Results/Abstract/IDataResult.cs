using System;
namespace K123Ecommerce.Core.Utilities.Results.Abstract
{
	public interface IDataResult<T> : IResult
	{
        public T Data { get; set; }
    }
}

