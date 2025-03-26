using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{    
    abstract class BaseNavigationViewModel<TEnum> : INotifyPropertyChanged where TEnum : Enum
    {
        private List<INavigatable<TEnum>> _viewModels = new List<INavigatable<TEnum>>();
        private INavigatable<TEnum>? currentViewModel;

        public event PropertyChangedEventHandler? PropertyChanged;

        public INavigatable<TEnum>? CurrentViewModel
        {
            get => currentViewModel;
            private set
            {
                currentViewModel = value;
                OnProperyChanged();
            }
        }

        internal void Navigate(TEnum type)
        {
            if (CurrentViewModel != null && CurrentViewModel.ViewModelType.Equals(type))
                return;

            INavigatable<TEnum> viewModel = GetViewModel(type);
            if (viewModel != null)
                CurrentViewModel = viewModel;
        }

        private INavigatable<TEnum>? GetViewModel(TEnum type)
        {
            INavigatable<TEnum> viewModel = _viewModels.FirstOrDefault(vm => vm.ViewModelType.Equals(type));
            if (viewModel == null)
            {
                viewModel = CreateViewModel(type);

                if (viewModel != null)
                    _viewModels.Add(viewModel);
            }
            return viewModel;
        }

        protected abstract INavigatable<TEnum>? CreateViewModel(TEnum type);

        protected virtual void ExitNavigation()
        {
            _viewModels.Clear();
            CurrentViewModel = null;
        }

        protected void OnProperyChanged([CallerMemberName]string? name=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
