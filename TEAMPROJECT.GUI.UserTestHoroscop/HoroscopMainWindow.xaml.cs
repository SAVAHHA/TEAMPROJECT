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
    /// Логика взаимодействия для HoroscopMainWindow.xaml
    /// </summary>
    public partial class HoroscopMainWindow : Window
    {
        User CurrentUser { get; set; }
        public HoroscopMainWindow(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }

        private void PredictionsButton_Click(object sender, RoutedEventArgs e)
        {
            PredictionWindow predictionWindow = new PredictionWindow(CurrentUser);
            predictionWindow.Show();
            this.Close();
        }
    }
}
