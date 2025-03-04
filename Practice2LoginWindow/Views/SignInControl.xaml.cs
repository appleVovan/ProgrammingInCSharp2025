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

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Views
{
    /// <summary>
    /// Interaction logic for SignInControl.xaml
    /// </summary>
    public partial class SignInView : UserControl
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set => _login = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public SignInView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            MessageBox.Show($"Login successful for user {Login}");
        }

        private void BSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login) || String.IsNullOrWhiteSpace(Password))
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

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = PbPassword.Password;
        }
    }
}
