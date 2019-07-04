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
    /// Interaction logic for BingDemo6.xaml
    /// </summary>
    public partial class BingDemo6 : Window
    {
        public BingDemo6()
        {
            InitializeComponent();
            SetBinding();
        }

        public void SetBinding()
        {
            //创建并配置ObjectDataProvider  属性作为Binding的path
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");

            //已ObjectDataProvider对象为source闯将Binding
            Binding binding1 = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                //表示值一变化即跟踪显示
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged

            };

            Binding binding2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding bingToResult = new Binding(".") { Source = odp };

            //将Binding 关联到UI元素上
            this.text1.SetBinding(TextBox.TextProperty, binding1);
            this.text2.SetBinding(TextBox.TextProperty, binding2);
            this.text3.SetBinding(TextBox.TextProperty, bingToResult);
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("100");
            odp.MethodParameters.Add("200");
            MessageBox.Show(odp.Data.ToString());
        }
    }
}
