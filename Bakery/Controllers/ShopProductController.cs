using Bakery.Backend.Models;
using Bakery.Interfaces;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bakery.Controllers
{
    public class ShopProductController : Controller
    {
        private readonly IAllProducts _productRep;
        private readonly ShopProducts _shopProducts;

        public ShopProductController(IAllProducts productRep, ShopProducts shopProducts)
        {
            _productRep = productRep;
            _shopProducts = shopProducts; 
        }

        public ViewResult Index()
        {
            var items = _shopProducts.getShopItems();
            _shopProducts.listShopItem = items;

            var obj = new ShopProductViewModel
            {
                shopProducts = _shopProducts
            };
            return View(obj);
        }

        public RedirectToActionResult addToProduct(int id)
        {
            var item = _productRep.Products.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopProducts.AddToProduct(item);
            }

            return RedirectToAction("Index");
        }
    }
}
