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
using TEAMPROJECT.Core;
using TEAMPROJECT.Core.Models;

namespace TEAMPROJECT.GUI.UserTestHoroscop
{
    /// <summary>
    /// Логика взаимодействия для AvtomatWindow.xaml
    /// </summary>
    public partial class AvtomatWindow : Window
    {
        User currentUser { get; set; }
        public AvtomatWindow(User CurrentUser)
        {
            InitializeComponent();
            TestResults new_testresult = new TestResults();
            new_testresult.PassDate = DateTime.Now;
            new_testresult.TestName = "Автомат по C#";
            //new_testresult.User =;
            new_testresult.ResultName = "Нет!";
            currentUser = CurrentUser;
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainMenuWindow(currentUser);
            window.Show();
            Close();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
