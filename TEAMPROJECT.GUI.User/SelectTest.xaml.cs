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
    /// Логика взаимодействия для SelectTest.xaml
    /// </summary>
    public partial class SelectTest : Window
    {
        public SelectTest()
        {
            InitializeComponent();
        }

        private void WinxTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new WinxFirstWindow();
            window.Show();
            Close();

        }

        private void PrepodTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new PrepodFirstWindow();
            window.Show();
            Close();
        }

        private void KorpusTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new KorpusFirstWindow();
            window.Show();
            Close();

        }

        private void AvtomatTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new AvtomatWindow();
            window.Show();
            Close();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
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
