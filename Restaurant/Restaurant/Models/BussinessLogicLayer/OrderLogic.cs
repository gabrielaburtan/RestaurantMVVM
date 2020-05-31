using Restaurant.Models.EntityLayer;
using Restaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Models.BussinessLogicLayer
{
    enum OrderState
    {
        Registered,
        Canceled
    }
    class OrderLogic
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private User activeUser = SignInViewModel.activeUser;
        public bool AddOrder(List<DisplayProduct> productsInCart, double price)
        {
            bool productType = false;
            foreach(var productInCart in productsInCart)
            {
                try
                {
                    var productQuery = (from product in restaurant.Products
                                        where product.Name.Equals(productInCart.Name)
                                        select product).First();
                    productType = true;
                    if(productQuery.Quantity > productQuery.QuatityInStore)
                    {
                        return false;
                    }
                }
                catch
                {
                    var menuQuery = (from menu in restaurant.Menus
                                     join menu_product in restaurant.Menu_Product
                                     on menu.Menu_ID equals menu_product.Menu_ID
                                     join product in restaurant.Products
                                     on menu_product.Product_ID equals product.Product_ID
                                     where menu.Name.Equals(productInCart.Name)
                                     select new { product.QuatityInStore, menu_product.Quantity }).First();

                    if (menuQuery.Quantity > menuQuery.QuatityInStore)
                    {
                        return false;
                    }
                }
            }

            Order newOrder = new Order()
            {
                User_ID = activeUser.User_ID,
                State = OrderState.Registered.ToString(),
                Date = DateTime.Now,
                Price = price
            };
            Properties.Settings.Default.Save();

            restaurant.Orders.Add(newOrder);

            foreach (var product in productsInCart)
            {
                if (productType == true)
                {
                    for (int numberOfProducts = 0; numberOfProducts < product.QuantityInCart; numberOfProducts++)
                    {
                        restaurant.Order_Product.Add(new Order_Product
                        {
                            Order_ID = newOrder.Order_ID,
                            Product_ID = (from productEntity in restaurant.Products
                                         where productEntity.Name.Equals(product.Name)
                                         select productEntity.Product_ID).First()
                        });
                    }
                }
                else
                {
                    for (int numberOfMenus = 0; numberOfMenus < product.QuantityInCart; numberOfMenus++)
                    {
                        restaurant.Order_Menu.Add(new Order_Menu
                        {
                            Order_ID = newOrder.Order_ID,
                            Menu_ID = (from menu in restaurant.Menus
                                       where menu.Name.Equals(product.Name)
                                       select menu.Menu_ID).First()

                        }); 
                    }
                }
            }

            restaurant.SaveChanges();
            return true;
        }
        public List<DisplayOrder> GetActiveOrders()
        {
            var activeOrders = (from order in restaurant.Orders
                                where order.User_ID.Equals(activeUser.User_ID)
                                && !order.State.Equals(OrderState.Canceled.ToString())
                                select new DisplayOrder
                                {
                                    Price = order.Price,
                                    Date = order.Date
                                }).ToList();

            return activeOrders;
        }
    }
}
