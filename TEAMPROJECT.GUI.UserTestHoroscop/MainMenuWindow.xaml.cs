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
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        User currentUser { get; set; }
        Repository repository = new Repository();

        public MainMenuWindow(User CurrentUser)
        {
            //if (UserId == 0) { //прописать
            //}
            InitializeComponent();
            WelcomeTextBlock.Text = "Добро пожаловать, " + CurrentUser.Name;
            currentUser = CurrentUser;

            //UserWelcome(......);
        }
        //public void UserWelcome(string name)
        //{
        //    WelcomeTextBlock.Text = $"Welcome, {name}!";
        //}

        private void Testi_Click(object sender, RoutedEventArgs e)
        {

            var window = new SelectTest(currentUser);
            window.Show();
            Close();

        }

        private void Goroskopi_Click(object sender, RoutedEventArgs e)
        {
            HoroscopMainWindow horoscopMainWindow = new HoroscopMainWindow(currentUser);
            horoscopMainWindow.Show();
            this.Close();
        }
    }
}
