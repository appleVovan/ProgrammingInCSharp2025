using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow
{
    /// <summary>
    /// Interaction logic for SignInControl.xaml
    /// </summary>
    public partial class SignInControl : UserControl, INotifyPropertyChanged
    {
        private string _login;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Login
        {
            get { return _login; }
            set 
            { 
                _login = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));
            }
        }

        public SignInControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(PbPassword.Password))
            {
                MessageBox.Show("Login or password is empty");
                Login = "EMPTY!!!";
                return;
            }
            MessageBox.Show($"Login successful for user {Login}");
        }

        private void BSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(PbPassword.Password))
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            MessageBox.Show($"User with name {Login} was created!");
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
