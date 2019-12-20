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

namespace TEAMPROJECT.GUI.UserTestHoroscop
{
    /// <summary>
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        GOROSCOPYRepository gOROSCOPYRepository = new GOROSCOPYRepository();
        Repository repository = new Repository();

        public LogInWindow()
        {
            InitializeComponent();
        }

        private void UserLogIn_Click(object sender, RoutedEventArgs e)
        {
            int id;
            bool check = repository.Entrance(UserLoginTextBox.Text, UserPasswordBox.Password, out id);
            if (check == true)
            {
                MainMenuWindow mainMenuWindow = new MainMenuWindow(id);//id);
                mainMenuWindow.Show();
                this.Close();
            }
            else
            {
                //alert window
            }
        }
    }
}
