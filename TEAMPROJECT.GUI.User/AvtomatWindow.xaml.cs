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
    /// Логика взаимодействия для AvtomatWindow.xaml
    /// </summary>
    public partial class AvtomatWindow : Window
    {
        public AvtomatWindow()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenuWindow();
            window.Show();
            Close();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
