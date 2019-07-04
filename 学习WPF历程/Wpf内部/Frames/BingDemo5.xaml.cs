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
using System.Windows.Shapes;

namespace Wpf内部.Frames
{
    /// <summary>
    /// Interaction logic for BingDemo5.xaml
    /// </summary>
    public partial class BingDemo5 : Window
    {
        public BingDemo5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //使用linq语句查询
            List<Student> studentList = new List<Student>()
            {
                new Student(){Id = 0,Name="a",Age=12},
                new Student(){Id = 1,Name="g",Age=132},
                new Student(){Id = 2,Name="r",Age=16}
            };
            this.listViewStudents.ItemsSource = from stu in studentList where stu.Id >= 1 select stu;

            

        }
    }
}
