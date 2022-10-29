using Bakery.Interfaces;
using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Backend.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;
        public ProductRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Product> Products => appDBContent.Product.Include(c => c.Category);

        public IEnumerable<Product> GetFavProducts => appDBContent.Product.Where(p => p.isFavourite).Include(c => c.Category);

        public Product getObjectProduct(int productID) => appDBContent.Product.FirstOrDefault(p => p.Id == productID);
    }
}
