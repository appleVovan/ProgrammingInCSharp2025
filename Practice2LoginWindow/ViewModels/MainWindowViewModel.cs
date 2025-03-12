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
    
    class MainWindowViewModel : BaseNavigationViewModel<MainNavigationType>
    {
        public MainWindowViewModel()
        {
            Navigate(MainNavigationType.Auth);
        }
                
        protected override void ExitNavigation()
        {
            base.ExitNavigation();
            Navigate(MainNavigationType.Auth);
        }

        protected override INavigatable<MainNavigationType>? CreateViewModel(MainNavigationType type)
        {
            switch (type)
            {
                case MainNavigationType.Auth:
                    return new AuthViewModel(() => Navigate(MainNavigationType.Main));
                case MainNavigationType.Main:
                    return new MainViewModel(ExitNavigation);
                default:
                    return null;
            }
        }
    }
}
