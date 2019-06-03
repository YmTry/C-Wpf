using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace X命名空间详解
{
    class MyButton :Button
    {
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            base.OnClick();//激发click事件
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win!=null)
            {
                win.ShowDialog();
            }
        }
    }
}
