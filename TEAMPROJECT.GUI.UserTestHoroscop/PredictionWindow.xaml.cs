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
    /// Логика взаимодействия для PredictionWindow.xaml
    /// </summary>
    public partial class PredictionWindow : Window
    {
        User curreUser { get; set; }
        Repository repository = new Repository();
        GOROSCOPYRepository gOROSCOPYRepository = new GOROSCOPYRepository();
        public PredictionWindow(User CurrentUser)
        {
            InitializeComponent();
            //PredictionText.Text = gOROSCOPYRepository.GetPrediction(CurrentUser.Zodiac.Name);
            PredictionText.Text = gOROSCOPYRepository.GetRandomPrediction();
        }
    }
}
