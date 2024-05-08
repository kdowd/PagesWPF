using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Page
    {
        private string whoa = "WHOA!";

        public Intro()
        {
            InitializeComponent();
            // AddTaskButton.Click += (object sender, RoutedEventArgs e) => { AddTaskButton_Click(sender, e, taskList); };
            //MessageBox.Show("Just about to show Intro");
            // introButton.Visibility = Visibility.Collapsed;
            //introButton.Click += (object sender, RoutedEventArgs e) => { MessageBox.Show("Just about to show Intro"); };
            // introButton.Click += (object sender, RoutedEventArgs e) => { showID(666); };

            introButton.Click += (object sender, RoutedEventArgs e) => { showID(666); };
        }

        private void showID(int id)
        {
            Console.WriteLine("ffffffffffffffffffffffffff");
            Debug.WriteLine("oh fuck off ");
            MessageBox.Show(id.ToString(), whoa);
        }

        private void IntroButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ahhhh");
        }


        private void ShowGame(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("Game.xaml", UriKind.Relative));

            //string senderName = ((FrameworkElement)sender).Name;
            //double senderName2 = ((FrameworkElement)sender).Width;
            //((FrameworkElement)sender).Visibility = Visibility.Collapsed;
            //MessageBox.Show(senderName2.ToString());
            //Debug.WriteLine("oh fuck off " );
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine(e.PropertyName);
            /*if (e.PropertyName == nameof(ActualLayer))
            {
                LayerSlider.Value = ActualLayer;
                ShowLayer();
                return;
            }*/
        }




    }
}
