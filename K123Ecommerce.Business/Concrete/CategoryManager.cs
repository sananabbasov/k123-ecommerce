using System;
using K123Ecommerce.Business.Abstract;
using K123Ecommerce.Core.Utilities.Results.Abstract;
using K123Ecommerce.Core.Utilities.Results.Concrete.ErrorResults;
using K123Ecommerce.Core.Utilities.Results.Concrete.SuccessResults;
using K123Ecommerce.DataAccess.Abstract;
using K123Ecommerce.Entities.Concrete;
using K123Ecommerce.Entities.DTOs.CategoryDTOs;

namespace K123Ecommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult AddCategory(CategoryAddDTO categoryAdd)
        {
            try
            {
                Category category = new()
                {
                    CategoryName = categoryAdd.CategoryName,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    PhotoUrl = categoryAdd.PhotoUrl
                };
                _categoryDal.Add(category);

                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }

        }

        public string AddWith()
        {
            return _categoryDal.AddWith();
        }

        public IDataResult<List<CategoryHomeListDTO>> GetHomeCategories()
        {
            var categories = _categoryDal.GetHomeCategoryList();
            if (categories.Count()  < 1)
            {
                return new ErrorDataResult<List<CategoryHomeListDTO>>(categories, "Product not found");
            }
            return new SuccessDataResult<List<CategoryHomeListDTO>>(categories);

        }
    }
}

