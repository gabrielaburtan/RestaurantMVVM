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
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private ObservableCollection<DisplayProduct> products;
        private MealLogic mealLogic = new MealLogic();
        public string SelectedAllergenProduct { get; set; }
        public string SelectedContainsOrNot { get; set; }


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

        private string contentTextBox;
        public string ContentTextBox
        {
            get
            {
                return contentTextBox;
            }
            set
            {
                contentTextBox = value;
                if (contentTextBox != "")
                {
                    CanExecuteSearch = true;
                }
                OnPropertyChanged("ContentTextBox");
            }
        }

        private bool CanExecuteSearch { get; set; } = false;
        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new RelayCommand(SearchMethod, param => CanExecuteSearch);
                }
                return searchCommand;
            }
        }
        private void SearchMethod(object param)
        {
            if (ContentTextBox != "")
            {
                if(SelectedAllergenProduct.Contains("Alergenul"))
                {
                    if(SelectedContainsOrNot.Contains("Contin"))
                    {
                        ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetProductsMenusByAllergen(ContentTextBox, true));
                    }
                    else
                    {
                        ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetProductsMenusByAllergen(ContentTextBox, false));
                    }
                }
                else
                {
                    if (SelectedContainsOrNot.Contains("Contin"))
                    {
                        ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetMealMenusByProduct(ContentTextBox, true));
                    }
                    else
                    {
                        ProductsCollection = new ObservableCollection<DisplayProduct>(mealLogic.GetMealMenusByProduct(ContentTextBox, false));
                    }
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
