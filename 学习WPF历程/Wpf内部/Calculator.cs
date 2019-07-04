using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf内部
{
    class Calculator
    {
        public string Add(string str1,string str2) {
            double x = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(str1, out x) && double.TryParse(str2,out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Input Error";
        }
    }
}
