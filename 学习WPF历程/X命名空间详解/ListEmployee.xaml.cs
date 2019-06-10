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
    /// Interaction logic for ListEmployee.xaml
    /// </summary>
    public partial class ListEmployee : Window
    {
        public static string ABC = "123";
        public ListEmployee()
        {
            //List<Employee> empList = new List<Employee>()
            //{
            //    new Employee(){Id = 1,Name = "Tom",Age = 30},
            //    new Employee(){Id = 2,Name = "Yom",Age = 312},
            //    new Employee(){Id = 3,Name = "Bom",Age = 4},
            //    new Employee(){Id = 4,Name = "Zom",Age = 2},
            //};
            
            InitializeComponent();
            List<Employe> employeList = new List<Employe>()
            {
                new Employe() {Id = 1, Name = "Tom"},
                new Employe() {Id = 2, Name = "Yom"},
                new Employe() {Id = 3, Name = "Bom"},
                new Employe() {Id = 4, Name = "Zom"},
            };
            
            this.ListBox1.ItemsSource = employeList;
        }
        public class Employe
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        
    }
}
