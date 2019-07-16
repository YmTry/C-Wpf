using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf内部
{
    class CategoryToSourceConverter : IValueConverter
    {
        //将Categoty转换成url
        public object ConverBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Category c = (Category)value;
            switch (c)
            {
                case Category.First:
                    return @"\Icons\First.jpg";
                case Category.Two:
                    return @"\Icons\Two.jpg";
                default:
                    return null;
            }
        }

        //单向转换该方法不会被调用
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StateToNullableBoolConverterL : IValueConverter
    {
        //将state转换为bool
        public object ConverBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            State s = (State)value;
            switch (s)
            {
                case State.Available:
                    return false;
                case State.Locker:
                    return true;
                case State.Unknown:
                default:
                    return null;
            }

        }

        //将bool转换成state bool?表示无法强转时则表示为null
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? b = (bool?)value;
            switch (b)
            {
                case true:
                    return State.Available;
                case false:
                    return State.Locker;
                case null:
                default:
                    return null;
            }
        }
    }
}
