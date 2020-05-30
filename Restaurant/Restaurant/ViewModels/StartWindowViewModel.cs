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
    class StartWindowViewModel : BaseViewModel
    {
        public static bool stateUser = false;
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
            SignInView signInView = new SignInView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signInView;
            signInView.Show();
        }

        private ICommand signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                if (signUpCommand == null)
                {
                    signUpCommand = new RelayCommand(SignUpMethod);
                }
                return signUpCommand;
            }
        }
        private void SignUpMethod(object param)
        {
            SignUpView signUpView = new SignUpView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = signUpView;
            signUpView.Show();
        }

        private ICommand withoutAccountCommand;
        public ICommand WithoutAccountCommand
        {
            get
            {
                if (withoutAccountCommand == null)
                {
                    withoutAccountCommand = new RelayCommand(WithoutAccountMethod);
                }
                return withoutAccountCommand;
            }
        }
        private void WithoutAccountMethod(object param)
        {
            CustomerView customerView = new CustomerView();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = customerView;
            customerView.Show();
        }
    }
}
