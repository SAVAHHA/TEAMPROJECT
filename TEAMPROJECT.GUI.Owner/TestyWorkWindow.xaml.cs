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

namespace TEAMPROJECT.GUI.Owner
{
    /// <summary>
    /// Логика взаимодействия для TestyWorkWindow.xaml
    /// </summary>
    public partial class TestyWorkWindow : Window
    {
        public TestyWorkWindow()
        {
            InitializeComponent();
        }

        private void OneTestButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomingWindow welcomingWindow = new WelcomingWindow();
            welcomingWindow.Show();
            this.Close();
        }
    }
}
