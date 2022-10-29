using Bakery.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Backend
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {                   
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Product.Any())
            {
                content.AddRange(
                    new Product
                    {
                        Name = "Хлеб Пшеничный (1с)",
                        Description = "Вес(кг): 0.52" +
                        "Срок реализации(час): 24",
                        Price = 24,
                        isFavourite = true,
                        img = "/img/Пшеничный.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Дарницкий",
                        Description = "Вес(кг): 0.50" +
                        "Срок реализации(час): 36",
                        Price = 21,
                        isFavourite = true,
                        img = "/img/Дарницкик.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Дачный (1с)(маленький)",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 24",
                        Price = 15,
                        isFavourite = false,
                        img = "/img/Дачный.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Ржано-пшеничный (маленький)",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 36",
                        Price = 14,
                        isFavourite = false,
                        img = "/img/Ржано.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Зерновой",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 36",
                        Price = 16,
                        isFavourite = true,
                        img = "/img/Зерновой.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Славянский",
                        Description = "Вес(кг): 0.5" +
                        "Срок реализации(час): 36",
                        Price = 22,
                        isFavourite = true,
                        img = "/img/Славянский.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб 'Бородино'",
                        Description = "Вес(кг): 0.35" +
                        "Срок реализации(час): 36",
                        Price = 22,
                        isFavourite = false,
                        img = "/img/Бородино.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Хлеб Пшеничный с отрубями(круглый)",
                        Description = "Вес(кг): 0.25" +
                        "Срок реализации(час): 24",
                        Price = 15,
                        isFavourite = false,
                        img = "/img/отрубями.jpg",
                        Category = Categories["Хлеб"]
                    },
                    new Product
                    {
                        Name = "Батон с надрезами(1с)",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 24",
                        Price = 24,
                        isFavourite = true,
                        img = "/img/батон.jpg",
                        Category = Categories["К чаю"]
                    },
                    new Product
                    {
                        Name = "Плетёнка с маком",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 24",
                        Price = 24,
                        isFavourite = true,
                        img = "/img/плетенка.jpg",
                        Category = Categories["К чаю"]
                    },
                    new Product
                    {
                        Name = "Солнышко с кунжутом",
                        Description = "Вес(кг): 0.3" +
                        "Срок реализации(час): 24",
                        Price = 24,
                        isFavourite = false,
                        img = "/img/Солнышко.jpg",
                        Category = Categories["К чаю"]
                    },
                    new Product
                    {
                        Name = "Батончик сдобный(ванильный)",
                        Description = "Вес(кг): 0.2" +
                        "Срок реализации(час): 24",
                        Price = 22,
                        isFavourite = true,
                        img = "/img/Сдобный.jpg",
                        Category = Categories["К чаю"]
                    },
                    new Product
                    {
                        Name = "Розанчик с повидном",
                        Description = "Вес(кг): 0.08" +
                        "Срок реализации(час): 12",
                        Price = 15,
                        isFavourite = true,
                        img = "/img/Розанчик.jpg",
                        Category = Categories["К чаю"]
                    }
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Хлеб", desc = "Хлебобулочное изделие, получаемое путём выпекания теста, разрыхлённого дрожжами или закваской."},
                        new Category {categoryName = "К чаю", desc = "К чаю традиционно подают десерты – пирожки и булочки, конфеты, кексы, печенья, – только лишь сладким ограничиваться не стоит."}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
