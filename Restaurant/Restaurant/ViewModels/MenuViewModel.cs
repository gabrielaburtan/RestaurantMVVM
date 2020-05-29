using Restaurant.Models;
using Restaurant.Models.BussinessLogicLayer;
using Restaurant.Models.EntityLayer;
using Restaurant.Services;
using Restaurant.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private ObservableCollection<DisplayProduct> products;
        private MealLogic mealLogic = new MealLogic();

        public ObservableCollection<DisplayProduct> ProductsCollection
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
                OnPropertyChanged("ProductsCollection");
            }
        }

        public MenuViewModel()
        {
            ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetProductsMenus());
        }

        #region SelectedProduct
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
                    CanExecuteDetailsCommand = true;
                }
                OnPropertyChanged("SelectedProduct");
            }
        }
        #endregion

        #region SeeDetailsCommand
        public bool CanExecuteDetailsCommand { get; set; }
        private ICommand detailsCommand;
        public ICommand DetailsCommand
        {
            get
            {
                if (detailsCommand == null)
                {
                    detailsCommand = new RelayCommand(DetailsMethod, param => CanExecuteDetailsCommand);
                }
                return detailsCommand;
            }
        }

        private void DetailsMethod(object param)
        {
            ProductDetailsView productDetailsView = new ProductDetailsView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = productDetailsView;
            productDetailsView.Show();
        }
        #endregion

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

        #region CategoryCommand
        private ICommand categoryCommand;
        public ICommand CategoryCommand
        {
            get
            {
                if (categoryCommand == null)
                {
                    categoryCommand = new RelayCommand(CategoryMethod);
                }
                return categoryCommand;
            }
        }
        private void CategoryMethod(object param)
        {
            ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetProductsMenusByCategory((param as Button).Content.ToString()));
        }
        #endregion
    }
}
