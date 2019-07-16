using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf内部
{
    //BingDemo8 
    public class RangeValidationRule : ValidationRule
    {
        //实现Validate方法 ValidationResult的IsValid属性为true则校验通过
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "failed");
        }
    }
}
