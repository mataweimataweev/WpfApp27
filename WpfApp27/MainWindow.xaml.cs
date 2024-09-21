using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            forPassword.Visibility = Visibility.Collapsed;
        }

        private void goTest_Click(object sender, RoutedEventArgs e)
        {
            //pageFrame.Content = new FirstPage();
            string password = forPassword.Text = "";
            FirstOkno tester = new(password);
            tester.ShowDialog();
        }

        private void createTest_Click(object sender, RoutedEventArgs e)
        {
            //pageFrame.Content = new SecondPage();
            forPassword.Visibility = Visibility.Visible;
        }

        private void forPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            string password = forPassword.Text;

            if (forPassword.Text == "admin")
            {
                FirstOkno test = new(password);
                test.ShowDialog();
            }
        }
    }
}