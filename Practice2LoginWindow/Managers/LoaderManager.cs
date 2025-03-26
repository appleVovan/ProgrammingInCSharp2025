using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Managers
{
    internal class LoaderManager
    {
        private static LoaderManager _instance;
        private static readonly object _locker = new object();
        private MainWindowViewModel _loaderOwner;

        public static LoaderManager Instance
        {
            get
            {
                if (_instance !=null)
                {
                    return _instance;
                }
                lock (_locker)
                {
                    return _instance ??= new LoaderManager();
                }
            }
        }

        private LoaderManager()
        {            
        }

        public void Initialize(MainWindowViewModel loaderOwner)
        {
            _loaderOwner = loaderOwner;
        }

        public void ShowLoader()
        {
            _loaderOwner.LoaderVisibility = Visibility.Visible;
            _loaderOwner.IsEnabled = false;
        }

        public void HideLoader()
        {
            _loaderOwner.LoaderVisibility = Visibility.Collapsed;
            _loaderOwner.IsEnabled = true;
        }
    }
}
