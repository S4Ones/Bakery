using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Interfaces;
using Bakery.Models;

namespace Bakery.Backend.mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        { 
           get
            {
                return new List<Category>
                { 
                    new Category {categoryName = "Хлеб", desc = "Хлебобулочное изделие, получаемое путём выпекания теста, разрыхлённого дрожжами или закваской."},
                    new Category {categoryName = "К чаю", desc = "К чаю традиционно подают десерты – пирожки и булочки, конфеты, кексы, печенья, – только лишь сладким ограничиваться не стоит."}
                };
            }
        }
    }
}
