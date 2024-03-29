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

namespace TEAMPROJECT.GUI.Owner
{
    /// <summary>
    /// Логика взаимодействия для AddPredictionWindow.xaml
    /// </summary>
    public partial class AddPredictionWindow : Window
    {
        public AddPredictionWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomingWindow welcomingWindow = new WelcomingWindow();
            welcomingWindow.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddingButton_Click(object sender, RoutedEventArgs e)
        {   
            if (PredskazaniyeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Предсказание не может быть пустым! Введите, пожалуйста, текст.", "Действие невозможно!", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Предсказание успешно добавлено!", "Поздравляем!", MessageBoxButton.OK);
                GOROSCOPYRepository _goroscopyRepo = new GOROSCOPYRepository();
                _goroscopyRepo.AddPrediction(PredskazaniyeTextBox.Text);
                _goroscopyRepo.RewritePredictions();
                PredskazaniyeTextBox.Clear();
            }
        }
    }
}
