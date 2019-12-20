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
    /// Логика взаимодействия для ChoosingTestWindow.xaml
    /// </summary>
    public partial class ChoosingTestWindow : Window
    {
        OWNERRepository ownerRepo { get; set; }
        public ChoosingTestWindow()
        {
            InitializeComponent();
            TESTYRepository _testyRepository = new TESTYRepository();
            TestsComboBox.ItemsSource = _testyRepository.allTests;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomingWindow welcomingWindow = new WelcomingWindow();
            welcomingWindow.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GetStatButton_Click(object sender, RoutedEventArgs e)
        {
            OneTestWindow oneTestWindow = new OneTestWindow(TestDatePicker.SelectedDate, TestsComboBox.SelectedIndex);
            oneTestWindow.Show();
            this.Close();
        }
    }
}
