using Bakery.Interfaces;
using Bakery.Models;
using Bakery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllProducts _productRep;

        public HomeController(IAllProducts productRep)
        {
            _productRep = productRep;
        }

        public ViewResult Index()
        {
            var homeProduct = new HomeViewModel
            {
                favProduct = _productRep.GetFavProducts
            };
            return View(homeProduct);
        }
    }
}
