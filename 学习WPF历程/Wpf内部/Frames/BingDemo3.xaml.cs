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
    /// Interaction logic for BingDemo3.xaml
    /// </summary>
    public partial class BingDemo3 : Window
    {
        public BingDemo3()
        {
            InitializeComponent();
            List<Student> studentList = new List<Student>()
            {
                new Student(){Id = 0, Name="12",Age=12},
                new Student(){Id = 1, Name="1",Age=56},
                new Student(){Id = 2, Name="ti",Age=32},
                new Student(){Id = 3, Name="bv",Age=176},
            };
            this.listBoxStudents.ItemsSource = studentList;
            //listBoxStudents.DisplayMemberPath = "Name";
            //TextBox设置Bingding
            //SelectedItem.Id表示选中listbox时的那条数据的Id
            this.textBoxId.SetBinding(TextBox.TextProperty, new Binding("SelectedItem.Id") { Source = this.listBoxStudents });
        }
    }
}
