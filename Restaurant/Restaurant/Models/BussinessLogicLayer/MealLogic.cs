using Restaurant.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models.BussinessLogicLayer
{
    class MealLogic
    {
        private RestaurantEntities restaurant = new RestaurantEntities();

        public List<DisplayProduct> GetProductsMenus()
        {
            var productQuery = (from product in restaurant.Products
                         select new DisplayProduct
                         {
                             Name = product.Name,
                             Quantity = product.Quantity,
                             Price = product.Price,
                             ProductTypeProperty = ProductType.Product
                         }).ToList();

            var menuQuery = (from menu in restaurant.Menus
                         select new DisplayProduct
                         {
                             Name = menu.Name,
                             ProductTypeProperty = ProductType.Menu
                         }).ToList();

            foreach (var menu in menuQuery)
            {
                menu.Quantity = (int)restaurant.GetQuantityFromProductsForMenu(menu.Name).First();
                menu.Price = (float)restaurant.GetPriceFromProductsForMenu(menu.Name).First();
            }

            productQuery.AddRange(menuQuery);

            return productQuery;
        }

        public List<DisplayProduct> GetProductsMenusByCategory(string category)
        {
            var productQuery = (from product in restaurant.Products
                                where product.Category.Name.Equals(category)
                                select new DisplayProduct
                                {
                                    Name = product.Name,
                                    Quantity = product.Quantity,
                                    Price = product.Price,
                                    ProductTypeProperty = ProductType.Product
                                }).ToList();

            var menuQuery = (from menu in restaurant.Menus
                             where menu.Category.Name.Equals(category)
                             select new DisplayProduct
                             {
                                 Name = menu.Name,
                                 ProductTypeProperty = ProductType.Menu
                             }).ToList();

            foreach (var menu in menuQuery)
            {
                menu.Quantity = (int)restaurant.GetQuantityFromProductsForMenu(menu.Name).First();
                menu.Price = (float)restaurant.GetPriceFromProductsForMenu(menu.Name).First();
            }

            productQuery.AddRange(menuQuery);

            return productQuery;
        }
    }
}
