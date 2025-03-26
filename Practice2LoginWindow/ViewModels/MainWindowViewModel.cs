using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
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
    
    class MainWindowViewModel : BaseNavigationViewModel<MainNavigationType>
    {
        private bool _isEnabled = true;
        private Visibility _loaderVisibility = Visibility.Collapsed;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnProperyChanged();
            }
        }

        public Visibility LoaderVisibility
        {
            get => _loaderVisibility;
            set
            {
                _loaderVisibility = value;
                OnProperyChanged();
            }
        }

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
