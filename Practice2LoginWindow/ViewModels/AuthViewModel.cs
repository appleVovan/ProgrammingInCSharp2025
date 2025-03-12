using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    enum AuthNavigationType
    {
        SignIn,
        SignUp
    }
    class AuthViewModel
    {
        private List<IAuthNavigatable> _viewModels = new List<IAuthNavigatable>();
        private Action _exitNavigation;

        public IAuthNavigatable? CurrentViewModel { get; private set; }

        public AuthViewModel(Action exitNavigation)
        {
            _exitNavigation = exitNavigation;
            Navigate(AuthNavigationType.SignIn);
        }

        internal void Navigate(AuthNavigationType type)
        {
            if (CurrentViewModel != null && CurrentViewModel.ViewModelType == type)
                return;

            IAuthNavigatable viewModel = GetViewModel(type);
            if (viewModel != null)
                CurrentViewModel = viewModel;
        }

        private IAuthNavigatable? GetViewModel(AuthNavigationType type)
        {
            IAuthNavigatable viewModel = _viewModels.FirstOrDefault(vm => vm.ViewModelType == type);
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
    }
}
