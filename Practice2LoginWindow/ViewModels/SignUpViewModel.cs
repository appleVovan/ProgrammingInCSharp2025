using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class SignUpViewModel : INavigatable<AuthNavigationType>
    {
        private RegistrationUser _user = new RegistrationUser();

        public string Login 
        { 
            get { return _user.Login; }
            set 
            { 
                _user.Login = value;
                UpdateCanExecute();
            }
        }
        public string Password
        {
            get { return _user.Password; }
            set 
            { 
                _user.Password = value;
                UpdateCanExecute();
            }
        }
        public string FirstName
        {
            get { return _user.FirstName; }
            set
            {
                _user.FirstName = value;
                UpdateCanExecute();
            }
        }
        public string LastName
        {
            get { return _user.LastName; }
            set
            {
                _user.LastName = value;
                UpdateCanExecute();
            }
        }

        public RelayCommand ToSignInCommand { get; }
        public RelayCommand SignUpCommand { get; }
        public RelayCommand CancelCommand { get; }
        public AuthNavigationType ViewModelType => AuthNavigationType.SignUp;

        public SignUpViewModel(Action toSignIn)
        {
            SignUpCommand ??= new RelayCommand(SignUp, CanExecute);
            ToSignInCommand = new RelayCommand(toSignIn);
            CancelCommand ??= new RelayCommand(() => Environment.Exit(0));
        }

        private void SignUp()
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(FirstName) || String.IsNullOrWhiteSpace(LastName))
                MessageBox.Show("Login, password, first name or last name is empty");
            else
            {
                var authService = new AuthenticationService();

                try
                {
                    authService.RegisterUser(_user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"User creation failed: {ex.Message}");
                    return;
                }

                MessageBox.Show($"User was registered. Please Sign In.");

                ToSignInCommand.Execute(null);
            }
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password) && !String.IsNullOrWhiteSpace(LastName) && !String.IsNullOrWhiteSpace(FirstName);
        }

        private void UpdateCanExecute()
        {
            SignUpCommand.NotifyCanExecuteChanged();
        }
    }
}
