using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf内部
{
    //自定义数据转换接口
    interface IValueConverter
    {
        //档binding的source流向Target时调用该方法 反之调用ConberBack  targetType确定方法的返回类型 parameter传递额外的信息
        object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        object ConverBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}
