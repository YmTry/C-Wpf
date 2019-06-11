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

namespace 控件与布局
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Tom",Age = 30},
                new Employee(){Id = 2,Name = "Yom",Age = 312},
                new Employee(){Id = 3,Name = "Bom",Age = 4},
                new Employee(){Id = 4,Name = "Zom",Age = 2},
            };
            this.ListBoxEmplyee.DisplayMemberPath = "Name";
            this.ListBoxEmplyee.SelectedValue = "Id";
            this.ListBoxEmplyee.ItemsSource = empList;
            InitializeComponent();
        }

        //private void btn_Victor(object sender, RoutedEventArgs e)
        //{
        //    Button btn = sender as Button;
        //    DependencyObject level1 = VisualTreeHelper.GetParent(btn);
        //    DependencyObject level2 = VisualTreeHelper.GetParent(level1);
        //    DependencyObject level3 = VisualTreeHelper.GetParent(level2);
        //    MessageBox.Show(level3.GetType().ToString() + "\n" + level2.GetType().ToString() + "\n" + level1.GetType().ToString());

        //}
    }
}
