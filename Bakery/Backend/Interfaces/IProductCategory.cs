using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Interfaces
{
    public interface IProductCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
