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
        User _currentUser { get; set; }
        public AvtomatWindow(User CurrentUser)
        {
            _currentUser = CurrentUser;
            InitializeComponent();
            TESTYRepository _testyrepository = new TESTYRepository();
            TestResults new_testresult = new TestResults();
            Repository _repository = new Repository();

            new_testresult.PassDate = DateTime.Now;
            new_testresult.TestName = "Автомат по C#";
            new_testresult.User = _currentUser;
            new_testresult.ResultName = "Нет!";

            _testyrepository.testResults.Add(new_testresult);
            _repository.Serialize("../../TEAMPROJECT.Core/Data/TestResults.json", _testyrepository.testResults);
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new WelcomeWindowUser();
            window.Show();
            Close();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
