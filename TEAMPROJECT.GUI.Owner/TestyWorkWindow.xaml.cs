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
            OWNERRepository _ownerRepo = new OWNERRepository();
            TESTYRepository _testRepo = new TESTYRepository();
            couUsTB.Text = _ownerRepo.CountUsersUsingTests().ToString();
            TotalTB.Text = _testRepo.testResults.Count().ToString();
        }

        private void OneTestButton_Click(object sender, RoutedEventArgs e)
        {
            ChoosingTestWindow choosingTestWindow = new ChoosingTestWindow();
            choosingTestWindow.Show();
            this.Close();
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
