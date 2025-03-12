using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class AuthViewModel : INotifyPropertyChanged, INavigatable<MainNavigationType>
    {
        private List<INavigatable<AuthNavigationType>> _viewModels = new List<INavigatable<AuthNavigationType>>();
        private Action _exitNavigation;
        private INavigatable<AuthNavigationType>? currentViewModel;

        public event PropertyChangedEventHandler? PropertyChanged;

        public INavigatable<AuthNavigationType>? CurrentViewModel
        {
            get => currentViewModel;
            private set
            {
                currentViewModel = value;
                OnProperyChanged();
            }
        }

        public MainNavigationType ViewModelType => MainNavigationType.Auth;

        public AuthViewModel(Action exitNavigation)
        {
            _exitNavigation = exitNavigation;
            Navigate(AuthNavigationType.SignIn);
        }

        internal void Navigate(AuthNavigationType type)
        {
            if (CurrentViewModel != null && CurrentViewModel.ViewModelType == type)
                return;

            INavigatable<AuthNavigationType> viewModel = GetViewModel(type);
            if (viewModel != null)
                CurrentViewModel = viewModel;
        }

        private INavigatable<AuthNavigationType>? GetViewModel(AuthNavigationType type)
        {
            INavigatable<AuthNavigationType> viewModel = _viewModels.FirstOrDefault(vm => vm.ViewModelType == type);
            if (viewModel == null)
            {
                switch (type)
                {
                    case AuthNavigationType.SignIn:
                        viewModel = new SignInViewModel(() => Navigate(AuthNavigationType.SignUp), ExitNavigation);
                        break;
                    case AuthNavigationType.SignUp:
                        viewModel = new SignUpViewModel(() => Navigate(AuthNavigationType.SignIn));
                        break;
                    default:
                        return null;
                }

                _viewModels.Add(viewModel);
            }
            return viewModel;
        }

        private void ExitNavigation()
        {
            _viewModels.Clear();
            CurrentViewModel = null;
            Navigate(AuthNavigationType.SignIn);
            _exitNavigation.Invoke();
        }

        private void OnProperyChanged([CallerMemberName]string? name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
