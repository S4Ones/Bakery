using Bakery.Interfaces;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Backend.Repository
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
