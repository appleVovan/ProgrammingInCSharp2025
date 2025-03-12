using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Models;
using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.ViewModels;
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
        public SignInView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ((SignInViewModel)DataContext).Password = PbPassword.Password;
        }
    }
}
