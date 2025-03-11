using KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Views;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToSignIn();
        }

        private void ToSignUp()
        {
            Content = new SignUpView(ToSignIn);
        }

        private void ToSignIn()
        {
            Content = new SignInView(ToSignUp);
        }
    }
}