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

namespace PagesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowIntro(object sender, RoutedEventArgs e)
        {
            App.Content = new Intro();
        }

        private void Sweet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("focued");
        }

        private void ShowGame(object sender, RoutedEventArgs e)
        {
            App.Content = new Game();
        }

        private void QuitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();


        }
    }
}