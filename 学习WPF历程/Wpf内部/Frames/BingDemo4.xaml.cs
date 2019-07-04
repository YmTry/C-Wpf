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
using System.Xml;

namespace Wpf内部.Frames
{
    /// <summary>
    /// Interaction logic for BingDemo4.xaml
    /// </summary>
    public partial class BingDemo4 : Window
    {
        public BingDemo4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"E:\GitRepository\学习WPF历程\Wpf内部\Config\RawData.xml");
            //XmlDataProvider xdp = new XmlDataProvider();
            //xdp.Document = doc;

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Source = new Uri(@"E:\GitRepository\学习WPF历程\Wpf内部\Config\RawData.xml");




            //使用xpath选中需要暴露 的数据，
            xdp.XPath = @"/StudetList/Student";
            this.listViewStudent.DataContext = xdp;
            this.listViewStudent.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
