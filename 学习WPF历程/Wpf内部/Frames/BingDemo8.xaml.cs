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
    /// Interaction logic for BingDemo8.xaml
    /// </summary>
    public partial class BingDemo8 : Window
    {
        public BingDemo8()
        {
            InitializeComponent();

            Binding binding = new Binding("Value")
            {
                Source = this.slider1,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            RangeValidationRule rvr = new RangeValidationRule();
            binding.ValidationRules.Add(rvr);
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
