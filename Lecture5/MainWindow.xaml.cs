using System.ComponentModel;
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

namespace KMA.ProgrammingInCSharp2025.Lecture5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
        }
    }

    class UserViewModel : INotifyPropertyChanged
    {
        private string _firstName = "Volodymyr";

        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        
        private string _lastName = "Yablonskyi";

        
        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


    }
}