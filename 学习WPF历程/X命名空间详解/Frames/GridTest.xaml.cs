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

namespace X命名空间详解.Frames
{
    /// <summary>
    /// Interaction logic for GridTest.xaml
    /// </summary>
    public partial class GridTest : Window
    {
        public GridTest()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.gridmain.ColumnDefinitions.Add(new ColumnDefinition());
            this.gridmain.ColumnDefinitions.Add(new ColumnDefinition());
            this.gridmain.ColumnDefinitions.Add(new ColumnDefinition());
            this.gridmain.ColumnDefinitions.Add(new ColumnDefinition());
            this.gridmain.RowDefinitions.Add(new RowDefinition());
            this.gridmain.RowDefinitions.Add(new RowDefinition());
            this.gridmain.RowDefinitions.Add(new RowDefinition());
            this.gridmain.ShowGridLines = true;
        }

    }
}
