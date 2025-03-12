﻿using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    enum MainNavigationType
    {
        Auth,
        Main
    }
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<IMainNavigatable> _viewModels = new List<IMainNavigatable>();
        private Action _exitNavigation;
        private IMainNavigatable? currentViewModel;

        public event PropertyChangedEventHandler? PropertyChanged;

        public IMainNavigatable? CurrentViewModel
        {
            get => currentViewModel;
            private set
            {
                currentViewModel = value;
                OnProperyChanged();
            }
        }

        public MainWindowViewModel(Action exitNavigation)
        {
            _exitNavigation = exitNavigation;
            Navigate(MainNavigationType.Auth);
        }

        internal void Navigate(MainNavigationType type)
        {
            if (CurrentViewModel != null && CurrentViewModel.ViewModelType == type)
                return;

            IMainNavigatable viewModel = GetViewModel(type);
            if (viewModel != null)
                CurrentViewModel = viewModel;
        }

        private IMainNavigatable? GetViewModel(MainNavigationType type)
        {
            IMainNavigatable viewModel = _viewModels.FirstOrDefault(vm => vm.ViewModelType == type);
            if (viewModel == null)
            {
                switch (type)
                {
                    case MainNavigationType.Auth:
                        viewModel = new AuthViewModel(() => Navigate(MainNavigationType.Main));
                        break;
                    case MainNavigationType.Main:
                        viewModel = new MainViewModel(ExitNavigation);
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
            Navigate(MainNavigationType.Auth);
            _exitNavigation.Invoke();
        }

        private void OnProperyChanged([CallerMemberName]string? name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
