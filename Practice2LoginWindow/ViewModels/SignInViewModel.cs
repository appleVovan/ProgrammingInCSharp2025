using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class SignInViewModel : IAuthNavigatable
    {
        private UserCandidate _user = new UserCandidate();

        private Action _toMainAction;

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

        public RelayCommand SignInCommand { get; }
        public RelayCommand ToSignUpCommand { get; }
        public RelayCommand CancelCommand { get; }
        public int ViewModelType => 1;

        public SignInViewModel(Action toSignUp, Action toMain)
        {
            SignInCommand ??= new RelayCommand(SignIn, CanExecute);
            ToSignUpCommand = new RelayCommand(toSignUp);
            CancelCommand ??= new RelayCommand(() => Environment.Exit(0));
            _toMainAction = toMain;
        }

        private void SignIn()
        {
            MessageBox.Show($"Login successful for user {Login}");
            _toMainAction();
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password);
        }

        private void UpdateCanExecute()
        {
            SignInCommand.NotifyCanExecuteChanged();
        }
    }
}
