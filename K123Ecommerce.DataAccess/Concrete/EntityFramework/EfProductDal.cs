using System;
using K123Ecommerce.Core.DataAccess.EntityFramework;
using K123Ecommerce.DataAccess.Abstract;
using K123Ecommerce.Entities.Concrete;

namespace K123Ecommerce.DataAccess.Concrete.EntityFramework
{
	public class EfProductDal : EfRepositoryBase<Product, AppDbContext>, IProductDal
	{
	}
}

