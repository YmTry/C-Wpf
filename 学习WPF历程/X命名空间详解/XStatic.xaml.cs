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

namespace X命名空间详解
{
    /// <summary>
    /// XStatic.xaml 的交互逻辑
    /// </summary>
    ///
    
    public partial class XStatic : Window
    {
        public static string title = "wo de title";
        public XStatic()
        {
            InitializeComponent();
        }
    }
}
