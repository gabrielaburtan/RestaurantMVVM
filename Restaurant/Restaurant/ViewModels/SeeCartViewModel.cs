using Restaurant.Models.EntityLayer;
using Restaurant.Services;
using Restaurant.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    class SeeCartViewModel:BaseViewModel
    {
        public SeeCartViewModel()
        {
            foreach (var product in ProductsInCart)
            {
                Total += product.Price;
            }
        }
        private ObservableCollection<DisplayProduct> productsInCart = MenuViewModel.productsAddedToCart;

        public ObservableCollection<DisplayProduct> ProductsInCart
        {
            get
            {
                return productsInCart;
            }
            set
            {
                productsInCart = value;
                OnPropertyChanged("ProductsInCart");
            }
        }

        private double total;
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }

        private DisplayProduct selectedProduct;
        public DisplayProduct SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
                if (selectedProduct != null)
                {
                    CanExecuteDeleteCommand = true;
                }
                OnPropertyChanged("SelectedProduct");
            }
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

        #endregion

        public bool CanExecuteDeleteCommand { get; set; } = false;
        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                {
                    deleteCommand = new RelayCommand(DeleteMethod, param => CanExecuteDeleteCommand);
                }
                return deleteCommand;
            }
        }
        private void DeleteMethod(object param)
        {
            ObservableCollection<DisplayProduct> ProductsInCartCopy = new ObservableCollection<DisplayProduct>();
            if(SelectedProduct.QuantityInCart > 1)
            {
                SelectedProduct.QuantityInCart--;
                foreach(var product in ProductsInCart)
                {
                    if(product.Name == SelectedProduct.Name)
                    {
                        product.QuantityInCart = SelectedProduct.QuantityInCart;
                        product.Price = MenuViewModel.choosedProduct.Price * product.QuantityInCart;
                    }
                    ProductsInCartCopy.Add(product);
                }
                ProductsInCart = ProductsInCartCopy;         
                OnPropertyChanged("ProductsInCart");
                Total = 0;
                foreach (var product in ProductsInCart)
                {
                    Total += product.Price;
                }
                OnPropertyChanged("Total");
            }
            else
            {
                ProductsInCart.Remove(SelectedProduct);
                Total = 0;
                foreach (var product in ProductsInCart)
                {
                    Total += product.Price;
                }
                OnPropertyChanged("Total");
            }          
        }
    }
}
