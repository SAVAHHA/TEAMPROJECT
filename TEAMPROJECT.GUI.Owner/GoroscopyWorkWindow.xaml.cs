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
    /// Логика взаимодействия для GoroscopyWorkWindow.xaml
    /// </summary>
    public partial class GoroscopyWorkWindow : Window
    {
        public GoroscopyWorkWindow()
        {
            InitializeComponent();
            Repository _repo = new Repository();
            LastSixZodiac.ItemsSource = _repo.Zodiacs;
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

        private void AddPredictionButton_Click(object sender, RoutedEventArgs e)
        {
            AddPredictionWindow addPredictionWindow = new AddPredictionWindow();
            addPredictionWindow.Show();
            this.Close();
        }
    }
}
