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

namespace ЧЗКзаеб
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainframe.Navigate(new MainPage());
        }

        private void stud_btn_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new E1());
        }

        private void teach_btn_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new E2());
        }

        private void sub_btn_Click(object sender, RoutedEventArgs e)
        {
            mainframe.Navigate(new E3());
        }
        private void mainframe_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}