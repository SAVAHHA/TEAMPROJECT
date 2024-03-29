﻿using System;
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
            User CurrentUser;
            bool check = repository.Entrance(UserLoginTextBox.Text, UserPasswordBox.Password, out CurrentUser);
            if (check == true)
            {
                MainMenuWindow mainMenuWindow = new MainMenuWindow(CurrentUser);
                Console.WriteLine(CurrentUser.Login);
                mainMenuWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не существует пользователя с таким логином и/или паролем", "Введите корректные данные или зарегистрируйтесь", MessageBoxButton.OK);
                UserLoginTextBox.Clear();
                UserPasswordBox.Clear();
            }
        }
    }
}
