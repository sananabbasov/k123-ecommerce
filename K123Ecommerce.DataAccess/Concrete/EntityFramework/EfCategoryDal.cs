using System;
using K123Ecommerce.Core.DataAccess.EntityFramework;
using K123Ecommerce.DataAccess.Abstract;
using K123Ecommerce.Entities.Concrete;
using K123Ecommerce.Entities.DTOs.CategoryDTOs;

namespace K123Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public string AddWith()
        {
            return "This data added with SQL";
        }

        public List<CategoryHomeListDTO> GetHomeCategoryList()
        {
            using var context = new AppDbContext();
            var categories = context.Categories
                                    .OrderByDescending(x => x.Id)
                                    .Take(12)
                                    .Select(x => new CategoryHomeListDTO
                                    {
                                        Id = x.Id,
                                        CategoryName = x.CategoryName,
                                        PhotoUrl = x.PhotoUrl
                                    })
                                    .ToList();
            return categories;
        }
    }
}

