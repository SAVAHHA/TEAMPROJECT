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

namespace TEAMPROJECT.GUI.User
{
    /// <summary>
    /// Логика взаимодействия для WelcomeWindowUser.xaml
    /// </summary>
    public partial class WelcomeWindowUser : Window
    {
        public WelcomeWindowUser()
        {
            InitializeComponent();
        }

        private void EnterAccountButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
