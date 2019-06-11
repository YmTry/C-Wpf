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

namespace SaveHuman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            AddEnemy();
        }

        private void AddEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy,0,PlayArea.ActualHeight -100, "(Canvas.Left)");
            AnimateEnemy(enemy,random.Next((int)PlayArea.ActualHeight-100),random.Next((int)PlayArea.ActualHeight-100),"(Canvas.Top)");
            PlayArea.Children.Add(enemy);
        }

        private void AnimateEnemy(ContentControl enemy, int from, double to, string propertyToAnimate)
        {
            Storyboard storyBoard = new Storyboard(){AutoReverse = true,RepeatBehavior = RepeatBehavior.Forever};
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4,6)))
            };
            Storyboard.SetTarget(animation,enemy);
            Storyboard.SetTargetProperty(animation, new PropertyPath(propertyToAnimate));
            storyBoard.Children.Add(animation);
            storyBoard.Begin();

        }
    }
}
