using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Ex02
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dnum = num;
            Console.WriteLine(num + " " + dnum);

            double dnum2 = 3.14;
            Console.WriteLine(dnum2 + " " + (int)dnum2);

            num = 200;
            Console.WriteLine(num + " " + (long)num);

            long lnum = 20000000000L;
            Console.WriteLine(lnum + " " + (int)lnum);
        }
    }
}
