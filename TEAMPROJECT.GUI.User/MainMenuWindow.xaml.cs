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

namespace TEAMPROJECT.GUI.User
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            
            InitializeComponent();
            //UserWelcome(......);
        }
        public void UserWelcome(string name)
        {
            WelcomeTextBlock.Text = $"Welcome, {name}!";
        }

        private void Testi_Click(object sender, RoutedEventArgs e)
        {
            var window = new SelectTest();
            window.Show();
            Close();

        }

        private void Goroskopi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
