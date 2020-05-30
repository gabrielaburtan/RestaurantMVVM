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
        public static ObservableCollection<DisplayProduct> productsAddedToCart = new ObservableCollection<DisplayProduct>();

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
        public static DisplayProduct choosedProduct;
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
                    choosedProduct = selectedProduct;
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

        #region SearchCommand
        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if(searchCommand == null)
                {
                    searchCommand = new RelayCommand(SearchMethod);
                }
                return searchCommand;
            }
        }
        private void SearchMethod(object param)
        {
            SearchView searchView = new SearchView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = searchView;
            searchView.Show();
        }
        #endregion

        #region CreateAccountCommand
        private ICommand accountCommand;
        public ICommand AccountCommand
        {
            get
            {
                if(accountCommand == null)
                {
                    accountCommand = new RelayCommand(AccountMethod);
                }
                return accountCommand;
            }
        }
        private void AccountMethod(object param)
        {
            SignUpView signUp = new SignUpView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signUp;
            signUp.Show();
        }
        #endregion

        #region SeeCart
        private ICommand seeCartCommand;
        public ICommand SeeCartCommand
        {
            get
            {
                if (seeCartCommand == null)
                {
                    seeCartCommand = new RelayCommand(SeeCartMethod);
                }
                return seeCartCommand;
            }
        }
        private void SeeCartMethod(object param)
        {
            SeeCartView seeCartView = new SeeCartView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = seeCartView;
            seeCartView.Show();
        }
        #endregion

        #region AddToCart
        private ICommand addToCartCommand;
        public ICommand AddToCartCommand
        {
            get
            {
                if (addToCartCommand == null)
                {
                    addToCartCommand = new RelayCommand(AddToCartMethod);
                }
                return addToCartCommand;
            }
        }
        private void AddToCartMethod(object param)
        {
            
            try
            {
                DisplayProduct copySelected = new DisplayProduct(SelectedProduct.Name, SelectedProduct.Price, SelectedProduct.QuantityInCart);
                copySelected.QuantityInCart = 1;
                bool exists = false;
                double initialPrice = copySelected.Price;
                foreach (var product in productsAddedToCart)
                {
                    if (product.Name == copySelected.Name)
                    {
                        product.QuantityInCart++;
                        product.Price = product.QuantityInCart * initialPrice;
                        exists = true;
                        MessageBox.Show("Produsul a fost adaugat in cos!");
                        SelectedProduct = null;
                    }
                }
                if (exists == false)
                {
                    productsAddedToCart.Add(copySelected);
                    MessageBox.Show("Produsul a fost adaugat in cos!");
                    SelectedProduct = null;
                }
            }
            catch
            {
                MessageBox.Show("Va rog selectati un produs!")
;            }
        }
        #endregion

    }
}
