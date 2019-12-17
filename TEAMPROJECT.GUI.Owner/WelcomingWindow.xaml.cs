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
    /// Логика взаимодействия для WelcomingWindow.xaml
    /// </summary>
    public partial class WelcomingWindow : Window
    {
        public WelcomingWindow()
        {
            InitializeComponent();
        }

        private void GoroscoryStatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            GoroscopyWorkWindow goroscopy = new GoroscopyWorkWindow();
            goroscopy.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TestStatisticsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
