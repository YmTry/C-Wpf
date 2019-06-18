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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SaveHuman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        private DispatcherTimer targeTimer = new DispatcherTimer();
        private bool humanCapTured = false;

        public MainWindow()
        {
            InitializeComponent();

            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targeTimer.Tick += TargeTimer_Tick;
            targeTimer.Interval = TimeSpan.FromSeconds(0.1);

        }

        private void TargeTimer_Tick(object sender, EventArgs e)
        {
            progerssBar.Value += 1;
            if (progerssBar.Value >= progerssBar.Maximum)
            {
                EndGame();
            };

        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            AddEnemy();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, PlayArea.ActualHeight - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)PlayArea.ActualHeight - 100), random.Next((int)PlayArea.ActualHeight - 100), "(Canvas.Top)");
            PlayArea.Children.Add(enemy);
        }

        private void AnimateEnemy(ContentControl enemy, int from, double to, string propertyToAnimate)
        {
            Storyboard storyBoard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
            };
            Storyboard.SetTarget(animation, enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            storyBoard.Children.Add(animation);
            storyBoard.Begin();
        }

        private void StartGame()
        {
            human.IsHitTestVisible = true;
            humanCapTured = false;
            progerssBar.Value = 0;
            StartButton.Visibility = Visibility.Collapsed;
            PlayArea.Children.Clear();
            PlayArea.Children.Add(target);
            PlayArea.Children.Add(human);
            enemyTimer.Start();
            targeTimer.Start();
        }
        //停止游戏
        private void EndGame()
        {
            if (!PlayArea.Children.Contains(gameOverText))
            {
                enemyTimer.Stop();
                targeTimer.Stop();
                humanCapTured = false;
                StartButton.Visibility = Visibility.Visible;
                PlayArea.Children.Add(gameOverText);
            }
            -
        }
    }
}
