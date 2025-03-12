using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class MainViewModel : IMainNavigatable
    {
        public MainNavigationType ViewModelType => MainNavigationType.Main;

        public MainViewModel(Action logout)
        {
            
        }
    }
}
