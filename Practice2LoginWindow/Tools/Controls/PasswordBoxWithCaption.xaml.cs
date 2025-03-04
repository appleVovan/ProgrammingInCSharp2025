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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KMA.ProgrammingInCSharp2025.Practice2LoginWindow.Tools.Controls
{
    /// <summary>
    /// Interaction logic for TextBoxWithCaption.xaml
    /// </summary>
    public partial class PasswordBoxWithCaption : UserControl
    {
        public event EventHandler<RoutedEventArgs> PasswordChanged;
        public string Caption 
        { 
            get
            {
                return TbCaption.Text;
            }
            set
            {
                TbCaption.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return PbValue.Password;
            }
            set
            {
                PbValue.Password = value;
            }
        }

        public PasswordBoxWithCaption()
        {
            InitializeComponent();
        }

        private void PbValue_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordChanged?.Invoke(sender, e);
        }
    }
}
