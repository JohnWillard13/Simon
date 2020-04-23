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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;


namespace Simon
{
    public partial class MainWindow : Window
    {
        List<int> userPattern = new List<int>();

        Random random = new Random();
        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Use TextBlock clearing to say "Watch the pattern", "Your Turn" and then an empty box between games
        async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            RedButton.Background = Brushes.White;
            await Task.Delay(TimeSpan.FromSeconds(0.75));
            RedButton.Background = Brushes.Red;
        }

        public void Game()
        {
            List<int> randomPattern = new List<int>();
            randomPattern.Add(random.Next(4));
            randomPattern.Add(random.Next(4));

            //foreach(int i in randomPattern)
            //{
            //}



        }


        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
                   
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
