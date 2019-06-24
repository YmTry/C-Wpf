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

namespace Wpf内部
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string WindowTitle = "test";
        private Student stu;
        public MainWindow()
        {
            InitializeComponent();
            ////准备数据源
            //stu = new Student();
            ////准备数据绑定
            //Binding binding = new Binding();
            //binding.Source = stu;
            //binding.Path = new PropertyPath("Name");
            ////使用Binding连接数据源与Binding目标
            //BindingOperations.SetBinding(this.text, TextBox.TextProperty, binding);
            this.text.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });
        }

        private void ChangeText_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "Name";
        }
    }
}
