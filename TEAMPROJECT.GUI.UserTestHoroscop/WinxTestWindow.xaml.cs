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
    /// Логика взаимодействия для WinxTestWindow.xaml
    /// </summary>
    public partial class WinxTestWindow : Window
    {
        private TESTYRepository _testyrepository = new TESTYRepository();

        int winxcount = 0;

        int Result1 = 0;
        int Result2 = 0;
        int Result3 = 0;
        int Result4 = 0;
        int Result5 = 0;
        int Result6 = 0;

        public WinxTestWindow()
        {
            InitializeComponent();
            QuestionTextBlock.Text = _testyrepository.TextQATest(_testyrepository.winxtest, winxcount);
            Answer1.Content = _testyrepository.TextA1Test(_testyrepository.winxtest, winxcount);
            Answer2.Content = _testyrepository.TextA2Test(_testyrepository.winxtest, winxcount);
            Answer3.Content = _testyrepository.TextA3Test(_testyrepository.winxtest, winxcount);
            Answer4.Content = _testyrepository.TextA4Test(_testyrepository.winxtest, winxcount);

        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {


            int answernumber1 = 1;
            _testyrepository.ButtonTestLogic(_testyrepository.winxtest, winxcount, answernumber1, Result1, Result2, Result3, Result4, Result5, Result6);

            winxcount++;

            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                var window = new ResultWinxWindow();
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
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                var window = new ResultWinxWindow();
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
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                var window = new ResultWinxWindow();
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
            if (winxcount == _testyrepository.winxtest.Count / 4)
            {
                var window = new ResultWinxWindow();
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
