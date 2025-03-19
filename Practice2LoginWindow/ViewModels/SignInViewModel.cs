using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class SignInViewModel : INavigatable<AuthNavigationType>, INotifyPropertyChanged
    {
        private UserCandidate _user = new UserCandidate();

        private Action _toMainAction;

        private bool _isEnabled = true;

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
        public AuthNavigationType ViewModelType => AuthNavigationType.SignIn;

        public bool IsEnabled 
        { 
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnProperyChanged();
            }
        }

        public SignInViewModel(Action toSignUp, Action toMain)
        {
            SignInCommand ??= new RelayCommand(SignIn, CanExecute);
            ToSignUpCommand = new RelayCommand(toSignUp);
            CancelCommand ??= new RelayCommand(() => Environment.Exit(0));
            _toMainAction = toMain;
        }

        private async void SignIn()
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(Password))
                MessageBox.Show("Login or password is empty");
            else
            {
                var authService = new AuthenticationService();

                User user = null;
                try
                {
                    IsEnabled = false;
                    user = await Task.Run(() => authService.Authenticate(_user));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sign in failed: {ex.Message}");
                    return;
                }
                finally
                { 
                    IsEnabled = true; 
                }

                MessageBox.Show($"Sign in was successful for user {user.FirstName} {user.LastName}!");

                _toMainAction?.Invoke();
            }
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(Login) && !String.IsNullOrWhiteSpace(Password);
        }

        private void UpdateCanExecute()
        {
            SignInCommand.NotifyCanExecuteChanged();
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnProperyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        } 
        #endregion
    }
}
