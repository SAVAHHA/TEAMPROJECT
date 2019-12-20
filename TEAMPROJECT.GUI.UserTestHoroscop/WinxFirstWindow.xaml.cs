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
    /// Логика взаимодействия для WinxFirstWindow.xaml
    /// </summary>
    public partial class WinxFirstWindow : Window
    {
        User currentUser { get; set; }
        public WinxFirstWindow(User CurrentUser)
        {
            //PhonImage.ImageSource = "phon.png";
            InitializeComponent();
            currentUser = CurrentUser;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            var window = new WinxTestWindow(currentUser);
            window.Show();
            Close();


        }
    }
}
