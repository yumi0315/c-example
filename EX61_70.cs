using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX61_70 {
        static void Main(string[] args) {
            // 61
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //char op = Convert.ToChar(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //switch (op) {
            //    case '+':
            //        result = n1 + n2;
            //        break;
            //    case '-':
            //        result = n1 - n2;
            //        break;
            //    case '*':
            //        result = n1 * n2;
            //        break;
            //    case '/':
            //        result = n1 / n2;
            //        break;
            //}
            //Console.WriteLine(result);

            // 62
            //int grade = Convert.ToInt32(Console.ReadLine());
            //int classNum = Convert.ToInt32(Console.ReadLine());
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{grade}{classNum:00}{number:000}");

            // 63
            //int day = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(day*24);

            // 64
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(n1 % n2);

            // 65
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++) {
            //    char[] text = i.ToString().ToCharArray();
            //    for (int j = 0; j < text.Length; j++) {
            //        Console.Write((int)(text[j] - '0') % 3 == 0 && text[j]!='0' ? "X" : text[j]);
            //    }
            //    Console.WriteLine(" ");
            //}

            // 66
            //int input = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //int count = 1;
            //while(input >= result) {
            //    result += count++;
            //}
            //Console.WriteLine(result);

            // 67
            //int input = Convert.ToInt32(Console.ReadLine());
            //while(input > 0) {
            //    Console.WriteLine(input--);
            //}

            // 68
            //int input = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while(input >= count) {
            //    Console.WriteLine(count++);
            //}

            // 69
            //int a = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a + (d * (n - 1)));

            // 70
            int a = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            while (n-- > 1) a *= d;
            Console.WriteLine(a);
        }
    }
}
