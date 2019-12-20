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
    /// Логика взаимодействия для CompabilityWindow.xaml
    /// </summary>
    public partial class CompabilityWindow : Window
    {
        GOROSCOPYRepository gOROSCOPYRepository = new GOROSCOPYRepository();
        public CompabilityWindow(User currentUser)
        {
            InitializeComponent();
            CompabilityListBox.ItemsSource = gOROSCOPYRepository.GetCompability(currentUser.Zodiac.Name);
            Zodiac1TextBlock.Text = "Совместимость с: " + currentUser.Zodiac.Name;
            //foreach (var compability in gOROSCOPYRepository.GetCompability(currentUser.Zodiac.Name))
            //{
            //    compability.
            //}
        }
    }
}
