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

        public IAuthNavigatable CurrentViewModel { get; private set; }

        public AuthViewModel()
        {
            
        }

        internal void Navigate(int type)
        {
            if (CurrentViewModel != null && CurrentViewModel.ViewModelType == type)
                return;

            IAuthNavigatable viewModel = GetViewModel(type);
            if (viewModel != null)
                CurrentViewModel = viewModel;
        }

        private IAuthNavigatable? GetViewModel(int type)
        {
            IAuthNavigatable viewModel = _viewModels.FirstOrDefault(vm => vm.ViewModelType == type);
            if (viewModel == null)
            {
                switch (type)
                {
                    case 1:
                        viewModel = new SignInViewModel(() => Navigate(2), ExitNavigation);
                        break;
                    case 2:
                        viewModel = new SignUpViewModel(() => Navigate(1));
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
            throw new NotImplementedException();
        }
    }
}
