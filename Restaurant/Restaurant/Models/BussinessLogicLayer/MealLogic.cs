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
                                where product.Category.Name.Contains(category)
                                select new DisplayProduct
                                {
                                    Name = product.Name,
                                    Quantity = product.Quantity,
                                    Price = product.Price,
                                    ProductTypeProperty = ProductType.Product
                                }).ToList();

            var menuQuery = (from menu in restaurant.Menus
                             where menu.Category.Name.Contains(category)
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
        public List<DisplayProduct> GetProductsMenusByAllergen(string allergenName, bool contains)
        {
            List<DisplayProduct> list = new List<DisplayProduct>();

            if (contains == true)
            {
                var productQuery = restaurant.GetProductsByAllergen(allergenName);
                foreach (var product in productQuery)
                {
                    list.Add(new DisplayProduct
                    {
                        CategoryName = product.CategoryName,
                        Price = product.Price,
                        Name = product.Name,
                        Quantity = product.Quantity
                    });
                }

                var menuQuery = restaurant.GetMenusByAllergen(allergenName);
                foreach (var menu in menuQuery)
                {
                    list.Add(new DisplayProduct
                    {
                        CategoryName = menu.Category,
                        Price = (double)menu.Price,
                        Name = menu.Name,
                        Quantity = (int)menu.Quantity
                    });
                }
                return list;
            }
            else
            {
                var productQuery = (from product in restaurant.Products
                                    select new DisplayProduct
                                    {
                                        CategoryName = product.Category.Name,
                                        Price = product.Price,
                                        Quantity = product.Quantity,
                                        Name = product.Name
                                    }).ToList();
                List<DisplayProduct> products = new List<DisplayProduct>();
                foreach (var product in productQuery)
                {
                    product.Allergens = restaurant.GetAllergensFromProduct(product.Name).ToList();
                    bool exist = false;
                    foreach (var allergen in product.Allergens)
                    {
                        if(allergen.ToLower().Contains(allergenName.ToLower()))
                        {
                            exist = true;
                            break;
                        }
                    }
                    if(exist == false)
                    {
                        products.Add(product);
                    }
                }

                var menuQuery = (from menu in restaurant.Menus
                                    select new DisplayProduct
                                    {
                                        CategoryName = menu.Category.Name,
                                        Quantity = (int)(from menu_product in restaurant.Menu_Product
                                                         where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                                         select menu_product.Quantity).Sum(),
                                        Price = (from product in restaurant.Products
                                                 join menu_product in restaurant.Menu_Product
                                                 on product.Product_ID equals menu_product.Product_ID
                                                 where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                                 select product.Price).Sum(),
                                        Name = menu.Name
                                    }).ToList();
                List<DisplayProduct> menus = new List<DisplayProduct>();
                foreach (var menu in menuQuery)
                {
                    menu.Allergens = restaurant.GetAllergensFromProduct(menu.Name).ToList();
                    bool exist = false;
                    foreach (var allergen in menu.Allergens)
                    {
                        if (allergen.ToLower().Contains(allergenName.ToLower()))
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        menus.Add(menu);
                    }
                }
                products.AddRange(menus);
                return products;
            }
        }

        public List<DisplayProduct> GetMealMenusByProduct(string productName, bool contains)
        {
            if (contains == true)
            {
                var productQuery = (from product in restaurant.Products
                                    where product.Name.Contains(productName)
                                    select new DisplayProduct
                                    {
                                        Name = product.Name,
                                        CategoryName = product.Category.Name,
                                        Price = product.Price,
                                        Quantity = product.Quantity
                                    }).ToList();
                var menuQuery = (from menu in restaurant.Menus
                                 join menu_product in restaurant.Menu_Product
                                 on menu.Menu_ID equals menu_product.Menu_ID
                                 join product in restaurant.Products
                                 on menu_product.Product_ID equals product.Product_ID
                                 where product.Name.Contains(productName)
                                 select new DisplayProduct
                                 {
                                     Name = menu.Name,
                                     CategoryName = menu.Category.Name,
                                     Price = (from product in restaurant.Products
                                              join menu_product in restaurant.Menu_Product
                                              on product.Product_ID equals menu_product.Product_ID
                                              where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                              select product.Price).Sum(),
                                     Quantity = (from menu_product in restaurant.Menu_Product
                                                 where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                                 select menu_product.Quantity).Sum()
                                 }).ToList();
                productQuery.AddRange(menuQuery);
                return productQuery;
            }

            else
            {
                var productQuery = (from product in restaurant.Products
                                    where !product.Name.Contains(productName)
                                    select new DisplayProduct
                                    {
                                        Name = product.Name,
                                        CategoryName = product.Category.Name,
                                        Price = product.Price,
                                        Quantity = product.Quantity
                                    }).ToList();
                var menuQuery = (from menu in restaurant.Menus
                                 join menu_product in restaurant.Menu_Product
                                 on menu.Menu_ID equals menu_product.Menu_ID
                                 join product in restaurant.Products
                                 on menu_product.Product_ID equals product.Product_ID
                                 where !product.Name.Contains(productName)
                                 select new DisplayProduct
                                 {
                                     Name = menu.Name,
                                     CategoryName = menu.Category.Name,
                                     Price = (from product in restaurant.Products
                                              join menu_product in restaurant.Menu_Product
                                              on product.Product_ID equals menu_product.Product_ID
                                              where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                              select product.Price).Sum(),
                                     Quantity = (from menu_product in restaurant.Menu_Product
                                                 where menu.Menu_ID.Equals(menu_product.Menu_ID)
                                                 select menu_product.Quantity).Sum()
                                 }).ToList();
                productQuery.AddRange(menuQuery);
                return productQuery;
            }
        }
    }
}
