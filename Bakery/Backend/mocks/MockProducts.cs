﻿using Bakery.Interfaces;
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
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 23,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Дарницкий",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 21,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Дачный (1с)(маленький)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 15.5,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Ржано-пшеничный (маленький)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 14.5,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Зерновой",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 16,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Славянский",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Бородино",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Хлеб Пшеничный с отрубями(круглый)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 15,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        Name = "Батон с надрезами(1с)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Батон с надрезами(1с)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Плетёнка с маком",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Солнышко с кунжутом",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 24,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Батончик сдобный(ванильный)",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
                        Price = 22,
                        isFavourite = true,
                        img = "",
                        Category = _categoryProducts.AllCategories.Last()
                    },
                    new Product
                    {
                        Name = "Розанчик с повидном",
                        Description = "Хлеб пшеничный – одно из самых популярных хлебобулочных изделий. Отличается прекрасным вкусом и сбалансированным составом полезных микроэлементов. Уже не одно столетие хлеб пшеничный – главный продукт на столе.",
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
