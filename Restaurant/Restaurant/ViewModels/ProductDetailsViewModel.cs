using Restaurant.Models;
using Restaurant.Models.EntityLayer;
using Restaurant.Services;
using Restaurant.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    class ProductDetailsViewModel
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        DisplayProduct selectedProduct = MenuViewModel.choosedProduct;
        public string ProductName
        {
            get
            {
                return MenuViewModel.choosedProduct.Name;
            }
        }

        private bool productType = false;
        public string Category
        {
            get
            {
                try
                {
                    var productQuery = (from category in restaurant.Categories
                                        join product in restaurant.Products
                                        on selectedProduct.Name equals product.Name
                                        where category.Category_ID.Equals(product.Category_ID)
                                        select category.Name).First();
                    productType = true;
                    return productQuery.ToString();                   
                }
                catch
                {
                    var menuQuery = (from category in restaurant.Categories
                                     join menu in restaurant.Menus
                                     on selectedProduct.Name equals menu.Name
                                     where category.Category_ID.Equals(menu.Category_ID)
                                     select category.Name).First();
                    return menuQuery.ToString();
                }
            }
        }

        public string Price
        {
            get
            {
                return MenuViewModel.choosedProduct.Price.ToString() + " RON";
            }
        }

        public string Quantity
        {
            get
            {
                if (Category == "Ciorbe" || Category == "Bauturi")
                {
                    return MenuViewModel.choosedProduct.Quantity.ToString() + " ML";
                }
                else
                {
                    return MenuViewModel.choosedProduct.Quantity.ToString() + " GR";
                }
            }
        }

        public string Allergens
        {
            get
            {
                string result = "";

                if (productType == true)
                {
                    var query = restaurant.GetAllergensFromProduct(selectedProduct.Name);
                    foreach (var allergen in query)
                    {
                        result = result + allergen.ToString() + " ";
                    }
                }

                else
                {
                    var query = restaurant.GetAllergensFromMenus(selectedProduct.Name);
                    foreach (var allergen in query)
                    {
                        result = result + allergen.ToString() + " ";
                    }
                }

                if (result == "")
                {
                    result = "-";
                }

                return result;
            }
        }

        public byte[] FirstImage
        {
            get
            {
                try
                {
                    var productQuery = (from product in restaurant.Products
                                        where product.Name.Equals(selectedProduct.Name)
                                        select product.Photo1).First();
                    return productQuery;
                }
                catch
                {
                    var menuQuery = (from menu in restaurant.Menus
                                     where menu.Name.Equals(selectedProduct.Name)
                                     select menu.Photo1).First();
                    return menuQuery;
                }
            }
        }

        public byte[] SecondImage
        {
            get
            {
                try
                {
                    var productQuery = (from product in restaurant.Products
                                        where product.Name.Equals(selectedProduct.Name)
                                        select product.Photo2).First();
                    return productQuery;
                }
                catch
                {
                    var menuQuery = (from menu in restaurant.Menus
                                     where menu.Name.Equals(selectedProduct.Name)
                                     select menu.Photo2).First();
                    return menuQuery;
                }
            }
        }

        private ICommand backCommand;
        public ICommand BackCommand
        {
            get
            {
                if (backCommand == null)
                {
                    backCommand = new RelayCommand(BackMethod);
                }
                return backCommand;
            }
        }
        private void BackMethod(object param)
        {
            if (StartWindowViewModel.stateUser == false)
            {
                MenuView startWindow = new MenuView();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = startWindow;
                startWindow.Show();
            }
            else
            {
                MenuForAccount startWindow = new MenuForAccount();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = startWindow;
                startWindow.Show();
            }
        }
    }
}
