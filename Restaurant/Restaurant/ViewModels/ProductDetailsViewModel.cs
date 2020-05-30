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

        public string Category
        {
            get
            {
                var query = (from category in restaurant.Categories
                             join product in restaurant.Products
                             on selectedProduct.Name equals product.Name
                             where category.Category_ID.Equals(product.Category_ID)
                             select category.Name).First();
                return query.ToString();
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
                if(Category == "Ciorbe" || Category == "Bauturi")
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
                var query = restaurant.GetAllergensFromProduct(selectedProduct.Name);
                foreach(var allergen in query)
                {
                    result = result + allergen.ToString() + " ";
                }
                if(result == "")
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
                var query = (from product in restaurant.Products
                             where product.Name.Equals(selectedProduct.Name)
                             select product.Photo1).First();
                return query;
            }
        }

        public byte[] SecondImage
        {
            get
            {
                var query = (from product in restaurant.Products
                             where product.Name.Equals(selectedProduct.Name)
                             select product.Photo2).First();
                return query;
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
            if(StartWindowViewModel.stateUser == false)
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
