using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX1_10 {
        static void Main(string[] args) {
            // 1
            Console.WriteLine("Hello");

            // 2
            Console.WriteLine("Hello World");

            // 3
            Console.WriteLine("Hello\nWorld");

            // 4
            Console.WriteLine("\'Hello\'");

            // 5
            Console.WriteLine("\"Hello\"");

            // 6
            Console.WriteLine("C:\\Download\\hello.java");

            // 7
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            // 8
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // 9
            double dNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dNum);

            // 10
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);

        }
    }
}
