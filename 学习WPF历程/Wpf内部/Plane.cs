using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf内部
{
    //自定义数据类型
    public enum Category
    {
        First,
        Two
    }
    public enum State
    {
        Available,
        Locker,
        Unknown
    }
    class Plane
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
