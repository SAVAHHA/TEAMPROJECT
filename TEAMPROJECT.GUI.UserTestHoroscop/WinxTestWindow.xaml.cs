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

        string qText;
        string a1Text;
        string a2Text;
        string a3Text;
        string a4Text;
        public WinxTestWindow()
        {
            InitializeComponent();
           // _testyrepository.TextQATest(_testyrepository.winxtest, winxcount, out qText, out a1Text, out a2Text, out a3Text, out a4Text);
            QuestionTextBlock.Text = qText;
            Answer1.Content = a1Text;
            Answer2.Content = a2Text;
            Answer3.Content = a3Text;
            Answer4.Content = a4Text;

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

        }
    }
}
