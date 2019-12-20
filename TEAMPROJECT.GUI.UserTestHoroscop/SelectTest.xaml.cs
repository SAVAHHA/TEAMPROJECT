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
using TEAMPROJECT.Core.Models;

namespace TEAMPROJECT.GUI.UserTestHoroscop
{
    /// <summary>
    /// Логика взаимодействия для SelectText.xaml
    /// </summary>
    public partial class SelectTest : Window
    {
        User CurrentUser { get; set; }
        public SelectTest(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void WinxTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new WinxFirstWindow(CurrentUser);
            window.Show();
            Close();

        }

        private void PrepodTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new PrepodFirstWindow(CurrentUser);
            window.Show();
            Close();
        }

        private void KorpusTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new KorpusFirstWindow(CurrentUser);
            window.Show();
            Close();

        }

        private void AvtomatTest_Click(object sender, RoutedEventArgs e)
        {
            var window = new AvtomatWindow(CurrentUser);
            window.Show();
            Close();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //var window = new MainMenuWindow(0);
            //window.Show();
            Close();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
