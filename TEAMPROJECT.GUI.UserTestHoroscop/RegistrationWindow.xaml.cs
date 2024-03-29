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

namespace TEAMPROJECT.GUI.UserTestHoroscop
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        GOROSCOPYRepository gOROSCOPYRepository = new GOROSCOPYRepository();
        Repository repository = new Repository();

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrationCancel_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindowUser welcomeWindow = new WelcomeWindowUser();
            welcomeWindow.Show();
            this.Close();
        }

        private void RegistrationOK_Click(object sender, RoutedEventArgs e)
        {
            if (repository.CheckLogin(UserLogin.Text) == true && UserLogin.Text != "" && UserName.Text != "" && UserPassword.Password != "" && UserDateOfBirth.Text != "")
            {
                repository.AddUser(UserName.Text, UserDateOfBirth.Text, UserLogin.Text, UserPassword.Password);
                LogInWindow logInWindow = new LogInWindow();
                logInWindow.Show();
                this.Close();
            }
            else if (repository.CheckLogin(UserLogin.Text) == false && UserLogin.Text != "" && UserName.Text != "" && UserPassword.Password != "" && UserDateOfBirth.Text != "")
            {
                UserLogin.Clear();
                MessageBox.Show("Пользователь с таким логином уже заргистрирован", "Измените логин или войдите", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Введите данные", MessageBoxButton.OK);
            }
        }

    }
}
