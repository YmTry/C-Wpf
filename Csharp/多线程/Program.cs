using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 72;
            ASCIIEncoding ae = new ASCIIEncoding();
            byte[] byteArray = new byte[] { (byte)i };
            string str = ae.GetString((byteArray));
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
