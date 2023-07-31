using System;
using K123Ecommerce.Core.Utilities.Results.Abstract;
using K123Ecommerce.Entities.DTOs.CategoryDTOs;

namespace K123Ecommerce.Business.Abstract
{
	public interface ICategoryService
	{
		IResult AddCategory(CategoryAddDTO categoryAdd);
		IDataResult<List<CategoryHomeListDTO>> GetHomeCategories();

        string AddWith();
    }
}

