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
    /// Interaction logic for BingDemo7.xaml
    /// </summary>
    public partial class BingDemo7 : Window
    {
        public BingDemo7()
        {
            InitializeComponent();

            //RelativeSource rs1 = new RelativeSource(RelativeSourceMode.Self);  表示关联自身  
            RelativeSource rs = new RelativeSource(RelativeSourceMode.FindAncestor);
            //目标控件为起点的层级偏移量，d2的偏移量是1
            rs.AncestorLevel = 1;
            rs.AncestorType = typeof(Grid);
            //使用属性作为path
            Binding binding = new Binding("Background") { RelativeSource = rs };
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
