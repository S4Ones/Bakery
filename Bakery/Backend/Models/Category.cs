using System.Collections.Generic;

namespace Bakery.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Product> Products { set; get; }
    }
}
