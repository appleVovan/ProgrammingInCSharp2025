using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Managers;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Navigation;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels
{
    class MainViewModel : INavigatable<MainNavigationType>, INotifyPropertyChanged
    {
        public MainNavigationType ViewModelType => MainNavigationType.Main;
        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnProperyChanged();
            }
        }

        public string CurrentUser 
        { 
            get
            {
                return $"Current User {ApplicationManager.CurrentUser.FirstName} {ApplicationManager.CurrentUser.LastName}";
            }            
        }

        public MainViewModel(Action logout)
        {
            _users = new ObservableCollection<User>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnProperyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public async Task Initialize()
        {
            var users = await new UserService().GetAllUsers();
            foreach (var user in users)
            {
                _users.Add(user);
            }
        }
    }
}
