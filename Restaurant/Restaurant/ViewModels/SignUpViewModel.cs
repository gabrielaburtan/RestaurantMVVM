using Restaurant.Models;
using Restaurant.Models.BussinessLogicLayer;
using Restaurant.Services;
using Restaurant.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Restaurant.ViewModels
{
    class SignUpViewModel:BaseViewModel
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        #region Properties

        private bool firstNameValidator = false;
        private string firstName;
        public string FirstNameProperty
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                Regex regex = new Regex(@"^[A-Z]{1}[a-z]+");
                if(regex.Match(firstName) == Match.Empty)
                {
                    CanExecuteSignUp = false;
                    firstNameValidator = false;
                    firstName = "";
                    MessageBox.Show("Prenume invalid!");
                }
                else
                {
                    firstNameValidator = true;
                }
                OnPropertyChanged("FirstNameProperty");
            }
        }

        private bool lastNameValidator = false;
        private string lastname;
        public string LastNameProperty
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                Regex regex = new Regex(@"^[A-Z]{1}[a-z]+");
                if (regex.Match(lastname) == Match.Empty)
                {
                    CanExecuteSignUp = false;
                    lastNameValidator = false;
                    lastname = "";
                    MessageBox.Show("Nume invalid!");
                }
                else
                {
                    lastNameValidator = true;
                }
                OnPropertyChanged("LastNameProperty");
            }
        }

        private bool addressValidator = false;
        private string address;
        public string AddressProperty
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                Regex regex = new Regex(@"^[A-Z]{1}[a-z]+\s[A-Z]{1}[a-z]+\s[0-9]+");
                if (regex.Match(address) == Match.Empty)
                {
                    CanExecuteSignUp = false;
                    addressValidator = false;
                    address = "";
                    MessageBox.Show("Adresa invalida!");
                }
                else
                {
                    addressValidator = true;
                }
                OnPropertyChanged("AddressProperty");
            }
        }

        private bool phoneNumberValidator = false;
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
                Regex regex = new Regex(@"^0{1}[0-9]{9}");
                if (regex.Match(phoneNumber) == Match.Empty)
                {
                    CanExecuteSignUp = false;
                    phoneNumberValidator = false;
                    phoneNumber = "";
                    MessageBox.Show("Numar de telefon invalid!");
                }
                else
                {
                    phoneNumberValidator = true;
                    if(firstNameValidator&&lastNameValidator&&emailValidator&&phoneNumberValidator&&addressValidator)
                    {
                        CanExecuteSignUp = true;
                    }
                }
                OnPropertyChanged("PhoneNumber");
            }
        }

        private bool emailValidator = false;
        private string email;
        public string EmailProperty
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                Regex regex = new Regex(@"^[A-Za-z0-9._]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
                if (regex.Match(email) == Match.Empty)
                {
                    CanExecuteSignUp = false;
                    emailValidator = false;
                    email = "";
                    MessageBox.Show("Email invalid!");
                }
                else
                {
                    emailValidator = true;
                }
                OnPropertyChanged("EmailProperty");
            }
        }
        #endregion

        #region SignInCommand

        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new RelayCommand(SignUpMethod, param => CanExecuteSignUp);
                }
                return signUpCommand;
            }
        }

        public bool CanExecuteSignUp { get; set; } = false;

        private void SignUpMethod(object param)
        {
            string password = (param as PasswordBox).Password;
            Regex employeeRegex = new Regex(@"@burtanica.ro$");
            if(employeeRegex.Match(email) != Match.Empty)
            {
                MessageBox.Show("Only managers can have this email!");
            }
            else
            {
                UserLogic user = new UserLogic();
                if (!user.SignUp(FirstNameProperty, LastNameProperty, PhoneNumber, EmailProperty, AddressProperty, password))
                {
                    MessageBox.Show("This email is taken!");
                    EmailProperty = "";
                }
                else
                {
                    var query = (from users in restaurant.Users
                                 where users.Email.Equals(EmailProperty)
                                 select users).First();
                    SignInViewModel.activeUser = query;
                    StartWindowViewModel.stateUser = true;
                    MenuForAccount menu = new MenuForAccount();
                    App.Current.MainWindow.Close();
                    App.Current.MainWindow = menu;
                    menu.Show();
                }
            }
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
    }
}
