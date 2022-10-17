using Bakery.Interfaces;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Backend.mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductCategory _categoryProducts = new MockCategory();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        Name = "Хлеб Пшеничный (1с)",
                        Description = "Вес(кг): 0.52",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Дарницкий",
                        Description = "Вес(кг): 0.50",
                        Price = 21,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Дачный (1с)(маленький)",
                        Description = "Вес(кг): 0.3",
                        Price = 15.5,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Ржано-пшеничный (маленький)",
                        Description = "Вес(кг): 0.3",
                        Price = 14.5,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Зерновой",
                        Description = "Вес(кг): 0.3",
                        Price = 16,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Славянский",
                        Description = "Вес(кг): 0.5",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Бородино",
                        Description = "Вес(кг): 0.35",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Пшеничный с отрубями(круглый)",
                        Description = "Вес(кг): 0.25",
                        Price = 15,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Батон с надрезами(1с)",
                        Description = "Вес(кг): 0.3",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Плетёнка с маком",
                        Description = "Вес(кг): 0.3",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Солнышко с кунжутом",
                        Description = "Вес(кг): 0.3",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Батончик сдобный(ванильный)",
                        Description = "Вес(кг): 0.2",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Розанчик с повидном",
                        Description = "Вес(кг): 0.08",
                        Price = 15,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product getObjectProduct(int productID)
        {
            throw new System.NotImplementedException();
        }
    }
}
