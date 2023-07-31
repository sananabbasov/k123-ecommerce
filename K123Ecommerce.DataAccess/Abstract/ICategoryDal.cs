using System;
using K123Ecommerce.Core.DataAccess;
using K123Ecommerce.Entities.Concrete;
using K123Ecommerce.Entities.DTOs.CategoryDTOs;

namespace K123Ecommerce.DataAccess.Abstract
{
	public interface ICategoryDal : IRespositoryBase<Category>
    {
		List<CategoryHomeListDTO> GetHomeCategoryList();
		string AddWith();
	}
}

