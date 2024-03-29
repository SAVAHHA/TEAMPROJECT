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
    /// Логика взаимодействия для WinxTestWindow.xaml
    /// </summary>
    public partial class WinxTestWindow : Window
    {
        User CurretUser { get; set; }
        private TESTYRepository _testyrepository = new TESTYRepository();
        private Repository _repository = new Repository();

        int winxcount = 0;

        int Result1 = 0;
        int Result2 = 0;
        int Result3 = 0;
        int Result4 = 0;
        int Result5 = 0;
        int Result6 = 0;
        User _user { get; set; }

        public WinxTestWindow(User currentUser)
        {
            InitializeComponent();
            _user = currentUser;
            QuestionTextBlock.Text ="      " +  _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);
            CurretUser = currentUser;
        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {


            int answernumber1 = 1;
            _testyrepository.ButtonTestLogic(_testyrepository.winxtest, winxcount, answernumber1, Result1, Result2, Result3, Result4, Result5, Result6);

            winxcount++;
            string testname = _testyrepository.TextNameTest(_testyrepository.winxtest);
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                TestResults new_testresult = new TestResults();
                new_testresult.PassDate = DateTime.Now;
                new_testresult.TestName = testname;
                new_testresult.User = _user;
                new_testresult.ResultName = _testyrepository.WinxTestResultLogic(Result1,Result2,Result3,Result4,Result5,Result6);

                _testyrepository.testResults.Add(new_testresult);
                Console.WriteLine(_testyrepository.testResults[0].ResultName);
                _repository.Serialize("../../TEAMPROJECT.Core/Data/TestResults.json", _testyrepository.testResults);
                var window = new ResultWinxWindow(new_testresult.ResultName);
                window.Show();
                Close();
            }
            QuestionTextBlock.Text = _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);

        }

        private void Answer3_Click(object sender, RoutedEventArgs e)
        {
            int answernumber3 = 3;
            _testyrepository.ButtonTestLogic(_testyrepository.winxtest, winxcount, answernumber3, Result1, Result2, Result3, Result4, Result5, Result6);
            winxcount++;
            string testname = _testyrepository.TextNameTest(_testyrepository.winxtest);
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                TestResults new_testresult = new TestResults();
                new_testresult.PassDate = DateTime.Now;
                new_testresult.TestName = testname;
                new_testresult.User = _user;
                new_testresult.ResultName = _testyrepository.WinxTestResultLogic(Result1, Result2, Result3, Result4, Result5, Result6);

                _testyrepository.testResults.Add(new_testresult);
                Console.WriteLine(_testyrepository.testResults[0].ResultName);
                _repository.Serialize("../../TEAMPROJECT.Core/Data/TestResults.json", _testyrepository.testResults);
                var window = new ResultWinxWindow(new_testresult.ResultName);
                window.Show();
                Close();
            }
            QuestionTextBlock.Text = _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);
        }

        private void Answer2_Click(object sender, RoutedEventArgs e)
        {
            int answernumber2 = 2;
            _testyrepository.ButtonTestLogic(_testyrepository.winxtest, winxcount, answernumber2, Result1, Result2, Result3, Result4, Result5, Result6);
            winxcount++;
            string testname = _testyrepository.TextNameTest(_testyrepository.winxtest);
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                TestResults new_testresult = new TestResults();
                new_testresult.PassDate = DateTime.Now;
                new_testresult.TestName = testname;
                new_testresult.User = _user;
                new_testresult.ResultName = _testyrepository.WinxTestResultLogic(Result1, Result2, Result3, Result4, Result5, Result6);

                _testyrepository.testResults.Add(new_testresult);
                Console.WriteLine(_testyrepository.testResults[0].ResultName);
                _repository.Serialize("../../TEAMPROJECT.Core/Data/TestResults.json", _testyrepository.testResults);
                var window = new ResultWinxWindow(new_testresult.ResultName);
                window.Show();
                Close();
            }
            QuestionTextBlock.Text = _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);
        }

        private void Answer4_Click(object sender, RoutedEventArgs e)
        {
            int answernumber4 = 4;
            _testyrepository.ButtonTestLogic(_testyrepository.winxtest, winxcount, answernumber4, Result1, Result2, Result3, Result4, Result5, Result6);
            winxcount++;

            string testname = _testyrepository.TextNameTest(_testyrepository.winxtest);
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                TestResults new_testresult = new TestResults();
                new_testresult.PassDate = DateTime.Now;
                new_testresult.TestName = testname;
                new_testresult.User = _user;
                new_testresult.ResultName = _testyrepository.WinxTestResultLogic(Result1, Result2, Result3, Result4, Result5, Result6);

                _testyrepository.testResults.Add(new_testresult);
                _repository.Serialize("../../TEAMPROJECT.Core/Data/TestResults.json", _testyrepository.testResults);

                var window = new ResultWinxWindow(new_testresult.ResultName);
                window.Show();
                Close();
            }
            QuestionTextBlock.Text = _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);
        }


    }
}
