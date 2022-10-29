using Bakery.Models;

namespace Bakery.Backend.Models
{
    public class ShopProductItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }

        public string ShopProductId { get; set; }
    }
}
