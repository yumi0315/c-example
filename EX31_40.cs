using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX31_40 {
        static void Main(string[] args) {
            // 31
            //char[] arr = { 'D', 'D', 'D', 'D', 'C', 'C', 'C', 'B', 'B', 'A' };
            //int score = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(arr[(int)score/10]);

            // 32
            //char c = Convert.ToChar(Console.ReadLine());
            //string ans = "";
            //switch (c) {
            //    case 'A':
            //        ans = "best!!!";
            //        break;
            //    case 'B':
            //        ans = "good!!";
            //        break;
            //    case 'C':
            //        ans = "run!";
            //        break;
            //    case 'D':
            //        ans = "slowly~";
            //        break;
            //    default:
            //        ans = "what?";
            //        break;
            //}
            //Console.WriteLine(ans);

            // 33
            //int month = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //switch (month) {
            //    case 12: case 1: case 2:
            //        ans = "winter";
            //        break;
            //    case 3: case 4: case 5:
            //        ans = "spring";
            //        break;
            //    case 6: case 7: case 8:
            //        ans = "summer";
            //        break;
            //    case 9: case 10: case 11:
            //        ans = "fall";
            //        break;
            //}
            //Console.WriteLine(ans);

            // 34
            //string str = "";
            //int num = 1;
            //while(true) {
            //    num = Convert.ToInt32(Console.ReadLine());
            //    str = str + num;
            //    if (num == 0) {                    
            //        break;
            //    }
            //}
            //for (int i = 0; i < str.Length; i++) {
            //    Console.WriteLine(str[i]);
            //}

            // 35
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for(int i = 2; i <= num; i += 2) {
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            // 36
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n1; i++) {
            //    for (int j = 1; j <= n2; j++) {
            //        Console.WriteLine(i + " " + j);
            //    }
            //}

            // 37
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++) {
            //    Console.WriteLine(new string('*', num));
            //}

            // 38
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(string.Format("{0:f1}",a*b/2));

            // 39
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Min( Math.Min(a, b), c));

            // 40
            double num = Convert.ToDouble(Console.ReadLine());
            if( num >= 50 && num <= 60 ) {
                Console.WriteLine("win");
            } else {
                Console.WriteLine("lose");
            }

        }
    }
}
