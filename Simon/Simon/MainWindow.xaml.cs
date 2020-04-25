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
        }

        //Use TextBlock clearing to say "Watch the pattern", "Your Turn" and then an empty box between games
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
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
            foreach(int i in randomPattern)
            {
                await Task.Delay(TimeSpan.FromSeconds(0.5));
                if (i == 0)
                {
                    GreenButton.Background = Brushes.White;
                    await Task.Delay(TimeSpan.FromSeconds(0.75));
                    GreenButton.Background = Brushes.Green;
                }

                else if (i == 1)
                {
                    RedButton.Background = Brushes.White;
                    await Task.Delay(TimeSpan.FromSeconds(0.75));
                    RedButton.Background = Brushes.Red;
                }

                else if (i == 2)
                {
                    YellowButton.Background = Brushes.White;
                    await Task.Delay(TimeSpan.FromSeconds(0.75));
                    YellowButton.Background = Brushes.Yellow;
                }

                else if (i == 3)
                {
                    BlueButton.Background = Brushes.White;
                    await Task.Delay(TimeSpan.FromSeconds(0.75));
                    BlueButton.Background = Brushes.Blue;
                }
            }
            
            StatusBox.Text = "Your turn.";

        }


        private void RedButton_Click(object sender, RoutedEventArgs e) //1
        {
            userPattern.Add(1);

            if (userPattern[counter] != randomPattern[counter])
            {
                userPattern.Clear();
                randomPattern.Clear();
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                MessageBox.Show("Wrong!");
                return;
            }

            else
            {
                counter++;
            }

            if(userPattern.Count == randomPattern.Count)
            {
                score++;
                MessageBox.Show("Congratulation! Your score is now " + score);
                ScoreBox.Text = "Score: " + score;

                if(score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                StartButton.IsEnabled = true;

            }

        }

        private void GreenButton_Click(object sender, RoutedEventArgs e) //0
        {
            userPattern.Add(0);

            if (userPattern[counter] != randomPattern[counter])
            {
                userPattern.Clear();
                randomPattern.Clear();
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                MessageBox.Show("Wrong!");
                return;

            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                MessageBox.Show("Congratulation! Your score is now " + score);
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                StartButton.IsEnabled = true;
            }
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e) //2
        {
            userPattern.Add(2);

            if (userPattern[counter] != randomPattern[counter])
            {
                userPattern.Clear();
                randomPattern.Clear();
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                MessageBox.Show("Wrong!");
                return;
            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                MessageBox.Show("Congratulation! Your score is now " + score);
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                StartButton.IsEnabled = true;
            }
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e) //3
        {
            userPattern.Add(3);

            if (userPattern[counter] != randomPattern[counter])
            {
                userPattern.Clear();
                randomPattern.Clear();
                StartButton.IsEnabled = true;
                ScoreBox.Text = "Score: " + 0;
                MessageBox.Show("Wrong!");
                return;
            }

            else
            {
                counter++;
            }

            if (userPattern.Count == randomPattern.Count)
            {
                score++;
                MessageBox.Show("Congratulation! Your score is now " + score);
                ScoreBox.Text = "Score: " + score;

                if (score > bestScore)
                {
                    bestScore = score;
                    HiScore.Text = "Top Score: " + bestScore;
                }

                userPattern.Clear();
                randomPattern.Add(random.Next(0, 4));
                StartButton.IsEnabled = true;
            }
        }
    }
}
