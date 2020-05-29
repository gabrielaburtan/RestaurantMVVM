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
                if(!user.SignIn(Email, password))
                {
                    MessageBox.Show("Email sau parola gresite!");
                    Email = "";
                    (param as PasswordBox).Password = "";
                }
                else
                {
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
