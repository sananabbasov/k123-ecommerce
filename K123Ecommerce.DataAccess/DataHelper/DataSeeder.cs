using System;
using Bogus;
using K123Ecommerce.DataAccess.Concrete.EntityFramework;
using K123Ecommerce.Entities.Concrete;

namespace K123Ecommerce.DataAccess.DataHelper
{
    public static class DataSeeder
    {
        public static void AddData()
        {
            using var context = new AppDbContext();


            if (!context.Categories.Any())
            {
                var fakeCategories = new Faker<Category>();

                fakeCategories.RuleFor(c=>c.CategoryName, z => z.Commerce.Categories(1)[0]);
                fakeCategories.RuleFor(c=>c.PhotoUrl, z => z.Image.PicsumUrl());
                fakeCategories.RuleFor(c => c.IsActive, z => z.Random.Bool());
                fakeCategories.RuleFor(c => c.CreatedDate, z => z.Date.Recent());

                var catList = fakeCategories.Generate(50);

                context.Categories.AddRange(catList);
                context.SaveChanges();

            }


            if (!context.Products.Any())
            {
                var fakeProducts = new Faker<Product>();

                fakeProducts.RuleFor(p => p.ProductName, u => u.Commerce.ProductName());
                fakeProducts.RuleFor(p => p.Price, u => u.Random.Decimal(50,500));
                fakeProducts.RuleFor(p => p.Discount, u => u.Random.Int(0,80));
                fakeProducts.RuleFor(p => p.IsActive, u => u.Random.Bool());
                fakeProducts.RuleFor(p => p.Quantity, u => u.Random.Int(1,700));
                fakeProducts.RuleFor(p => p.CategoryId, u => u.Random.Int(2,51));
                fakeProducts.RuleFor(p => p.Description, u => u.Commerce.ProductDescription());
                fakeProducts.RuleFor(p => p.Raiting, u => u.Random.Decimal(0, 10));
                fakeProducts.RuleFor(p => p.ProductAdjective, u => u.Commerce.ProductAdjective());


                var products = fakeProducts.Generate(100);

                context.Products.AddRange(products);
                context.SaveChanges();
            }

        }
    }
}

