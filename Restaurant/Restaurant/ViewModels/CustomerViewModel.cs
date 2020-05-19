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
    class CustomerViewModel:BaseViewModel
    {
        private ICommand viewMenu;
        public ICommand ViewMenu
        {
            get
            {
                if(viewMenu == null)
                {
                    viewMenu = new RelayCommand(ViewMenuMethod);
                }
                return viewMenu;
            }
        }
        private void ViewMenuMethod(object param)
        {
            MenuView menuView = new MenuView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuView;
            menuView.Show();
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
            StartWindow startWindow = new StartWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = startWindow;
            startWindow.Show();
        }
    }
}
