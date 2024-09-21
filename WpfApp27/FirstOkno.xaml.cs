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

namespace testGenerator
{
   
    public partial class FirstOkno : Window
    {
        public FirstOkno(string password)
        {
            InitializeComponent();
            ChangeTest.IsEnabled = password == "admin";
        }

        private void goTestOne_Click(object sender, RoutedEventArgs e)
        {
            ForThirdPage.Content = new ThirdPage();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void ChangeTest_Click(object sender, RoutedEventArgs e)
        {
            ForThirdPage.Content = new ForCreeateAndChangeTest();
        }
    }
}
