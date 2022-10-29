using Bakery.Models;
using System.Collections;
using System.Collections.Generic;

namespace Bakery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favProduct { get; set; }
    }
}
