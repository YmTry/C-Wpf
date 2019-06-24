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
    /// 简单用文字绑定
    /// </summary>
    public partial class BingDemo1 : Window
    {
        public BingDemo1()
        {
            InitializeComponent();
            this.textBox1.SetBinding(TextBox.TextProperty, new Binding("Value") { ElementName="slider1",UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged});
        }
    }
}
