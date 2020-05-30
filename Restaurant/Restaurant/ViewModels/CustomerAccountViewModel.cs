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
    class CustomerAccountViewModel
    {
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

        private ICommand seeMenuCommand;
        public ICommand SeeMenuCommand
        {
            get
            {
                if (seeMenuCommand == null)
                {
                    seeMenuCommand = new RelayCommand(SeeMenuMethod);
                }
                return seeMenuCommand;
            }
        }
        private void SeeMenuMethod(object param)
        {
            MenuForAccount menuWindow = new MenuForAccount();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();
        }

        private ICommand seeActiveOrdersCommand;
        public ICommand SeeActiveOrdersCommand
        {
            get
            {
                if (seeActiveOrdersCommand == null)
                {
                    seeActiveOrdersCommand = new RelayCommand(SeeActiveOrdersMethod);
                }
                return seeActiveOrdersCommand;
            }
        }
        private void SeeActiveOrdersMethod(object param)
        {
            MenuForAccount menuWindow = new MenuForAccount();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();
        }

        private ICommand seeOrderHistoryCommand;
        public ICommand SeeOrderHistoryCommand
        {
            get
            {
                if (seeOrderHistoryCommand == null)
                {
                    seeOrderHistoryCommand = new RelayCommand(SeeOrderHistoryMethod);
                }
                return seeOrderHistoryCommand;
            }
        }
        private void SeeOrderHistoryMethod(object param)
        {
            MenuForAccount menuWindow = new MenuForAccount();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();
        }
    }
}
