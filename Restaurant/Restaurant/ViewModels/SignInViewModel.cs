using Restaurant.Models;
using Restaurant.Models.BussinessLogicLayer;
using Restaurant.Services;
using Restaurant.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    class SignInViewModel : BaseViewModel
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        UserLogic user = new UserLogic();

        public SignInViewModel()
        {
            //Converter converter = new Converter();
            //try
            //{

            //    var productQuery = (from product in restaurant.Products
            //                 select product).ToList();

            //    int index = 0;
            //    foreach (var product in productQuery)
            //    {
            //        product.Photo1 = converter.Convert(converter.images[index++]);
            //        product.Photo2 = converter.Convert(converter.images[index++]);
            //        restaurant.Products.Attach(product);
            //        restaurant.Entry(product).Property(x => x.Photo1).IsModified = true;
            //        restaurant.Entry(product).Property(x => x.Photo2).IsModified = true;
            //    }

            //    var menuQuery = (from menu in restaurant.Menus
            //                 select menu).ToList();

            //    foreach (var menu in menuQuery)
            //    {
            //        menu.Photo1 = converter.Convert(converter.images[index++]);
            //        menu.Photo2 = converter.Convert(converter.images[index++]);
            //        restaurant.Menus.Attach(menu);
            //        restaurant.Entry(menu).Property(x => x.Photo1).IsModified = true;
            //        restaurant.Entry(menu).Property(x => x.Photo2).IsModified = true;
            //    }

            //    restaurant.SaveChanges();
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
        }

        #region BackCommand
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
            StartWindow startWindow = new StartWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = startWindow;
            startWindow.Show();
        }
        #endregion

        #region Properties
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        #endregion

        #region SignInCommand
        private ICommand signInCommand;
        public ICommand SignInCommand
        {
            get
            {
                if (signInCommand == null)
                {
                    signInCommand = new RelayCommand(SignInMethod);
                }
                return signInCommand;
            }
        }

        private void SignInMethod(object param)
        {
            string password = (param as PasswordBox).Password;
            if (Email == null || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }
            else
            {
                if (!user.SignIn(Email, password))
                {
                    MessageBox.Show("Email sau parola gresite!");
                    Email = "";
                    (param as PasswordBox).Password = "";
                }
                else
                {
                    StartWindowViewModel.stateUser = true;
                    MenuForAccount menu = new MenuForAccount();
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = menu;
                    menu.Show();
                }
            }
        }
        #endregion
    }
}
