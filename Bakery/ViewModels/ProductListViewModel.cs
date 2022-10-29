using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> getAllProducts { get; set; }
        public string currCategory { get; set; }
    }
}
