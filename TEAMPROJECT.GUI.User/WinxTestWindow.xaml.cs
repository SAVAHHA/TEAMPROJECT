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
using TEAMPROJECT.Core.Repository;

namespace TEAMPROJECT.GUI.User
{
    /// <summary>
    /// Логика взаимодействия для WinxTestWindow.xaml
    /// </summary>
    public partial class WinxTestWindow : Window
    {
        private TESTYRepository _testyrepository = new TESTYRepository();
        public WinxTestWindow()
        {
            InitializeComponent();
        }
        int winxcount = 0;
        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            winxcount++;

        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {
            winxcount++;

        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {
            winxcount++;

        }

        private void Answer4_Click(object sender, RoutedEventArgs e)
        {
            winxcount++;

        }
    }
}
