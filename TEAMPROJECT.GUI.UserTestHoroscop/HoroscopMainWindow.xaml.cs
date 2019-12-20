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

namespace TEAMPROJECT.GUI.UserTestHoroscop
{
    /// <summary>
    /// Логика взаимодействия для HoroscopMainWindow.xaml
    /// </summary>
    public partial class HoroscopMainWindow : Window
    {
        public HoroscopMainWindow()
        {
            InitializeComponent();
        }

        private void PredictionsButton_Click(object sender, RoutedEventArgs e)
        {
            PredictionWindow predictionWindow = new PredictionWindow();
            predictionWindow.Show();
            this.Close();
        }
    }
}
