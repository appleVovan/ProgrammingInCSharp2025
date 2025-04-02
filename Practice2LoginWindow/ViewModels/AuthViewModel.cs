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
    class AuthViewModel : BaseNavigationViewModel<AuthNavigationType>, INavigatable<MainNavigationType>
    {
        private Action _exitNavigation;
        public MainNavigationType ViewModelType => MainNavigationType.Auth;

        public AuthViewModel(Action exitNavigation)
        {
            _exitNavigation = exitNavigation;
        }

        protected override void ExitNavigation()
        {
            base.ExitNavigation();
            _exitNavigation.Invoke();
        }

        protected override INavigatable<AuthNavigationType>? CreateViewModel(AuthNavigationType type)
        {
            switch (type)
            {
                case AuthNavigationType.SignIn:
                    return new SignInViewModel(() => Navigate(AuthNavigationType.SignUp), ExitNavigation);
                case AuthNavigationType.SignUp:
                    return new SignUpViewModel(() => Navigate(AuthNavigationType.SignIn));
                default:
                    return null;
            }
        }

        public async Task Initialize()
        {
            Navigate(AuthNavigationType.SignIn);
        }
    }
}
