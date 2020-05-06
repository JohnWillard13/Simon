using System;
using System.IO;
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


namespace Simon
{
    public partial class MainWindow : Window
    {
        List<int> userPattern = new List<int>();

        Random random = new Random();
        int score = 0;
        List<int> randomPattern = new List<int> {};
        int counter = 0;
        int bestScore = 0;

        public MainWindow()
        {
            InitializeComponent();
            RedButton.IsEnabled = false;
            BlueButton.IsEnabled = false;
            GreenButton.IsEnabled = false;
            YellowButton.IsEnabled = false;
        }

        //Use TextBlock clearing to say "Watch the pattern", "Your Turn" and then an empty box between games
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            RedButton.IsEnabled = true;
            BlueButton.IsEnabled = true;
            GreenButton.IsEnabled = true;
            YellowButton.IsEnabled = true;

            StartButton.IsEnabled = false;
            if (randomPattern.Count == 0)
            {
                randomPattern.Add(random.Next(0, 4));
                randomPattern.Add(random.Next(0, 4));
            }
            StatusBox.Text = "Watch the Pattern.";
            ShowPattern();
        }

        async void ShowPattern()
        {
            try
            {
                StatusBox.Text = "Watch the Pattern.";

                if (score > 0)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1.5));
                }

                foreach (int i in randomPattern)
                {
                    await Task.Delay(TimeSpan.FromSeconds(0.5));
                    if (i == 0)
                    {
                        GreenButton.Background = Brushes.White;
                        Console.Beep();
                        await Task.Delay(TimeSpan.FromSeconds(0.75));
                        GreenButton.Background = Brushes.Green;
                    }

                    else if (i == 1)
                    {
                        RedButton.Background = Brushes.White;
                        Console.Beep();
                        await Task.Delay(TimeSpan.FromSeconds(0.75));
                        RedButton.Background = Brushes.Red;
                    }

                    else if (i == 2)
                    {
                        YellowButton.Background = Brushes.White;
                        Console.Beep();
                        await Task.Delay(TimeSpan.FromSeconds(0.75));
                        YellowButton.Background = Brushes.Yellow;
                    }

                    else if (i == 3)
                    {
                        BlueButton.Background = Brushes.White;
                        Console.Beep();
                        await Task.Delay(TimeSpan.FromSeconds(0.75));
                        BlueButton.Background = Brushes.Blue;
                    }
                }

                StatusBox.Text = "Your turn.";
                return;
            }

            catch(Exception e) {
                userPattern.Clear();
                randomPattern.Clear();
                score = 0;
                counter = 0;
                RedButton.IsEnabled = false;
                BlueButton.IsEnabled = false;
                GreenButton.IsEnabled = false;
                YellowButton.IsEnabled = false;
                StatusBox.Text = "Wait until the pattern is done being shown.";
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                return;
            }
        }

        private void RedButton_Click(object sender, RoutedEventArgs e) //1
        {
            Console.Beep();
            userPattern.Add(1);

            if (randomPattern[counter] != 1)
            {
                userPattern.Clear();
                randomPattern.Clear();
                score = 0;
                counter = 0;
                RedButton.IsEnabled = false;
                BlueButton.IsEnabled = false;
                GreenButton.IsEnabled = false;
                YellowButton.IsEnabled = false;
                StatusBox.Text = "You lose. Click Start to play again.";
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                return;
            }

            else
            {
                counter++;
            }

            if(userPattern.Count == randomPattern.Count)
            {
                score++;
                ScoreBox.Text = "Score: " + score;

                if(score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                counter = 0;
                ShowPattern();
            }

        }

        private void GreenButton_Click(object sender, RoutedEventArgs e) //0
        {
            Console.Beep();
            userPattern.Add(0);

            if (randomPattern[counter] != 0)
            {
                userPattern.Clear();
                randomPattern.Clear();
                score = 0;
                counter = 0;
                RedButton.IsEnabled = false;
                BlueButton.IsEnabled = false;
                GreenButton.IsEnabled = false;
                YellowButton.IsEnabled = false;
                StatusBox.Text = "You lose. Click Start to play again.";
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                return;

            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                counter = 0;
                ShowPattern();
            }
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e) //2

        {
            Console.Beep();
            userPattern.Add(2);

            if (randomPattern[counter] != 2)
            {
                userPattern.Clear();
                randomPattern.Clear();
                score = 0;
                counter = 0;
                RedButton.IsEnabled = false;
                BlueButton.IsEnabled = false;
                GreenButton.IsEnabled = false;
                YellowButton.IsEnabled = false;
                StatusBox.Text = "You lose. Click Start to play again.";
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                return;
            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                counter = 0;
                ShowPattern();
            }
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e) //3
        {
            Console.Beep();
            userPattern.Add(3);

            if (randomPattern[counter] != 3)
            {
                userPattern.Clear();
                randomPattern.Clear();
                score = 0;
                counter = 0;
                RedButton.IsEnabled = false;
                BlueButton.IsEnabled = false;
                GreenButton.IsEnabled = false;
                YellowButton.IsEnabled = false;
                StatusBox.Text = "You lose. Click Start to play again.";
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                return;
            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                counter = 0;
                ShowPattern();
            }
        }
    }
}
