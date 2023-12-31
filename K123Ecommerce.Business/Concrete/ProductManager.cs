﻿using System;
using K123Ecommerce.Business.Abstract;
using K123Ecommerce.DataAccess.Abstract;

namespace K123Ecommerce.Business.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
    }
}

