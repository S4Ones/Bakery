using Bakery.Interfaces;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductCategory _productCategory;

        public ProductsController(IAllProducts iAllProducts, IProductCategory iProductCategory)
        {
            _allProducts = iAllProducts;
            _productCategory = iProductCategory;
        }

        public ViewResult List()
        {
            ProductListViewModel obj = new ProductListViewModel();
            obj.getAllProducts = _allProducts.Products;
            obj.currCategory = "Свежий хлеб";
            return View(obj);
        }
    }
}
