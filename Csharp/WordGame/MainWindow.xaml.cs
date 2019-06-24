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
using System.Windows.Threading;

namespace WordGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private Random random = new Random();
        ASCIIEncoding ae = new ASCIIEncoding();
        Stats stats = new Stats();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);
            dispatcherTimer.Tick += addWords;
        }


        private void addWords(object sender, EventArgs e)
        {
            byte[] byteArray = new byte[] { (byte)random.Next(65, 90) };
            string word = ae.GetString(byteArray);
            listBox1.Items.Add(word);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.Key.ToString()))
            {
                listBox1.Items.Remove(e.Key.ToString());
                if (dispatcherTimer.Interval.Milliseconds > 400)
                    dispatcherTimer.Interval = TimeSpan.FromMilliseconds(dispatcherTimer.Interval.Milliseconds - 10);
                if (dispatcherTimer.Interval.Milliseconds > 250)
                    dispatcherTimer.Interval = TimeSpan.FromMilliseconds(dispatcherTimer.Interval.Milliseconds - 5);
                if (dispatcherTimer.Interval.Milliseconds > 100)
                    dispatcherTimer.Interval = TimeSpan.FromMilliseconds(dispatcherTimer.Interval.Milliseconds - 5);
                PB.Value = 800 - dispatcherTimer.Interval.Milliseconds;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }
            correctText.Text = "Correct:" + stats.correct;
            missedText.Text = "Missed:" + stats.missed;
            totalText.Text = "Total:" + stats.total;
            accuracyText.Text = "Accuracy:" + stats.accuracy + "%";
            
        }

        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
    }
}
