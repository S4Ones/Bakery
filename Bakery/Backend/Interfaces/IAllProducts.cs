using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> GetFavProducts { get; }
        Product getObjectProduct(int productID);

    }
}
