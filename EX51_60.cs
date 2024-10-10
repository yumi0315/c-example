using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX51_60 {
        static void Main(string[] args) {
            // 51
            //char[] input = Console.ReadLine().ToCharArray();
            //Array.Reverse(input);
            //int volume = int.Parse(input) * 2 % 100;
            //Console.WriteLine(volume);

            //if ( volume <= 50 ) {
            //    Console.WriteLine("GOOD");
            //} else {
            //    Console.WriteLine("OH MY GOD");
            //}

            // 52
            //string[] strArr = { "st", "nd", "rd", "th" };
            //string num = Console.ReadLine();
            //int numCastInt = (int)(num[num.Length - 1] - '0');
            //Console.WriteLine($"{num}{strArr[ numCastInt > 3 || numCastInt == 0 ? 3 : numCastInt-1 ]}");

            // 53
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());

            //double max = 0;

            //max = a + b > max ? a + b : max;
            //max = b + a > max ? b + a : max;

            //max = a - b > max ? a - b : max;
            //max = b - a > max ? b - a : max;

            //max = a * b > max ? a * b : max;
            //max = b * a > max ? b * a : max;

            //max = a / b > max ? a / b : max;
            //max = b / a > max ? b / a : max;

            //max = Math.Pow(a, b) > max ? Math.Pow(a, b) : max;
            //max = Math.Pow(b, a) > max ? Math.Pow(b, a) : max;

            //Console.WriteLine($"{max:0.000000}");

            // 54
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //if(a % b == 0) {
            //    Console.WriteLine($"{b}*{a/b}={a}");
            //} else if (b % a == 0) {
            //    Console.WriteLine($"{a}*{b / a}={b}");
            //} else {
            //    Console.WriteLine("none");
            //}

            // 55
            //char[] arr = { 'F', 'F', 'F', 'F', 'F', 'F', 'D', 'C', 'B', 'A', 'A' };
            //int score = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(arr[(int)score/10]);

            // 56
            //int[] input = new int[4];
            //string[] output = { "윷","도","개","걸","모" };
            //for (int i = 0; i < input.Length; i++) {
            //    input[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write(output[input.Where(x => x == 1).Count()]);

            // 57
            //int[] cal = { 0, 400, 340, 170, 100, 70 };
            //int totalCal = 0;
            //totalCal += cal[Convert.ToInt32(Console.ReadLine())];
            //totalCal += cal[Convert.ToInt32(Console.ReadLine())];

            //Console.WriteLine(totalCal > 500 ? "angry":"no angry");

            // 58
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine( c < a + b ? "yes" : "no" );

            // 59
            //int[] rotto = new int[7];
            //int[] myRotto = new int[6];

            //for (int i = 0; i < rotto.Length; i++) {
            //    rotto[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < myRotto.Length; i++) {
            //    myRotto[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int count = 0;
            //bool bonus = false;
            //for (int i = 0; i < rotto.Length; i++) {
            //    for (int j = 0; j < myRotto.Length; j++) {
            //        if ((i == rotto.Length - 1) && rotto[i] == myRotto[j]) {
            //            bonus = true;
            //            break;
            //        } else if (rotto[i] == myRotto[j]) {
            //            count++;
            //            break;
            //        }
            //    }
            //}
            //int rank = 0;
            //switch (count) {
            //    case 6:
            //        rank = 1;
            //        break;
            //    case 5:
            //        rank = bonus ? 2 : 3;
            //        break;
            //    case 4:
            //        rank = 4;
            //        break;
            //    case 3:
            //        rank = 5;
            //        break;
            //    default:
            //        rank = 0;
            //        break;
            //}
            //Console.WriteLine($"{(rank == 0 ? "꽝" : rank + "등")}");

            // 60
            //int[] heigh = new int[3];
            //for (int i = 0; i < heigh.Length; i++) {
            //    heigh[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //bool check = false;
            //for (int i = 0; i < heigh.Length; i++) {
            //    if(heigh[i] <= 170) {
            //        check = true;
            //        Console.WriteLine($"CRASH {heigh[i]}");
            //        break;
            //    }
            //}
            //if (!check) {
            //    Console.WriteLine("PASS");
            //}

        }
    }
}
