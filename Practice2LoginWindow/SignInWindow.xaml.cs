using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TbLogin.Text) || String.IsNullOrWhiteSpace(PbPassword.Password))
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            MessageBox.Show($"Login successful for user {TbLogin.Text}");
            Close();
        }

        private void BSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TbLogin.Text) || String.IsNullOrWhiteSpace(PbPassword.Password))
            {
                MessageBox.Show("Login or password is empty");
                return;
            }
            MessageBox.Show($"User with name {TbLogin.Text} was created!");
            Close();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
