using Bakery.Interfaces;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [Route("Product/List")]
        [Route("Product/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(_category))
            {
                products = _allProducts.Products.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Bread", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("Хлеб")).OrderBy(i => i.Id);
                    currCategory = "Свежий хлеб";
                }
                else
                {
                    if (string.Equals("ForTea", category, StringComparison.OrdinalIgnoreCase))
                    {
                        products = _allProducts.Products.Where(i => i.Category.categoryName.Equals("К чаю")).OrderBy(i => i.Id);
                        currCategory = "К чаю";
                    }
                }
            }

            var productObj = new ProductListViewModel
            {
                getAllProducts = products,
                currCategory = currCategory,
            };

            return View(productObj);
        }
    }
}
