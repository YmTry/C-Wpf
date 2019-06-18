using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Guide
{
    class Talker
    {
        public static int Blah(string thingToSay, int numberOfTimes)
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < numberOfTimes; i++)
            {
                sb.Append(thingToSay);
            }

            MessageBox.Show(sb.ToString());
            return sb.Length;
        }
    }
}
