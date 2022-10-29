using Bakery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Backend.Models
{
    public class ShopProducts
    {
        private readonly AppDBContent appDBContent;
        public ShopProducts(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopProductId { get; set; }
        public List<ShopProductItem> listShopItem { get; set; }

        public static ShopProducts GetProduct(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();
            string shopProductId = session.GetString("ProductId") ?? Guid.NewGuid().ToString();

            session.SetString("ProductId", shopProductId);

            return new ShopProducts(context) { ShopProductId = shopProductId };
        }

        public void AddToProduct(Product product)
        {
            appDBContent.ShopProductItems.Add(new ShopProductItem
            {
                ShopProductId = ShopProductId,
                product = product,
                price = product.Price   
            });

            appDBContent.SaveChanges();
        }

        public void RemoveFromProduct()
        {
            appDBContent.ShopProductItems.RemoveRange();
            appDBContent.SaveChangesAsync();
        }

        public List<ShopProductItem> getShopItems()
        {
            //return appDBContent.ShopProductItems.Where(c => c.ShopProductId == ShopProductId).Include(s => s.product).ToList();
            return appDBContent.ShopProductItems.Where(c => c.ShopProductId == ShopProductId).Include(s => s.product).ToList();
        }
    }
}
