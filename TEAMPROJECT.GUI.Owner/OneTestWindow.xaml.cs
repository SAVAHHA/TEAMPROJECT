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

namespace TEAMPROJECT.GUI.Owner
{
    /// <summary>
    /// Логика взаимодействия для OneTestWindow.xaml
    /// </summary>
    public partial class OneTestWindow : Window
    {
        public OneTestWindow(DateTime? date, int index)
        {
            InitializeComponent();
            OWNERRepository ownerRepo = new OWNERRepository();
            TESTYRepository _testRepo = new TESTYRepository();
            ownerRepo.selectedDate = date;
            ownerRepo.selectedTest = _testRepo.allTests[index];
            countOneTB.Text = ownerRepo.CountPassesOneDay().ToString();
            //periodTextBox.Text = _ownerRepo.selectedDate.ToString().Substring(0, 10);
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
