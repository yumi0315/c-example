using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX71_80 {
        static void Main(string[] args) {
            // 71
            //int num = new Random().Next(2,10);
            //int[] arr = new int[num];

            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum = arr.Sum();
            //Console.WriteLine(sum);

            // 72
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];

            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = arr.Max();
            //Console.WriteLine(max);

            // 73
            //int[] arr = { 1, 10, 2, 20, 3, 30, 4, 40, 5, 50, 6, 60, 7, 70, 8, 80, 9, 90, 10, 100, 11, 110, 12, 120 };
            //int k = Convert.ToInt32(Console.ReadLine());
            //int h = Convert.ToInt32(Console.ReadLine());
            //int money = arr[k - 1] + arr[h - 1];
            //Console.WriteLine(money);

            // 74
            //int N = Convert.ToInt32(Console.ReadLine());
            //SortedSet<int> list = new SortedSet<int>();
            //for (int i = 1; i <= Math.Sqrt(N); i++) {
            //    if (N % i == 0) {
            //        list.Add(N / i);
            //        list.Add(i);
            //    }
            //}
            //Console.WriteLine(string.Join(" ",list));

            // 75
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool check = true;
            //for (int i = 2; i <= Math.Sqrt(number); i++) {
            //    if (number % i == 0) {
            //        check = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(check?"prime":"no prime");

            // 76
            //int n = Convert.ToInt32(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());

            //int result = 1;
            //while(k-- > 0) {
            //    result *= n;
            //}
            //Console.WriteLine(result);

            // 77
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //while(number > 1) {
            //    result *= number--;
            //}
            //Console.WriteLine(result);

            // 78
            //int result = Convert.ToInt32(Console.ReadLine());
            //char op = Convert.ToChar(Console.ReadLine());
            //while(op != '=') {
            //    switch (op) {
            //        case '+':
            //            result += Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case '-':
            //            result -= Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case '*':
            //            result *= Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case '/':
            //            result /= Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //    op = Convert.ToChar(Console.ReadLine());
            //}
            //Console.WriteLine(result);

            // 79
            //char[] charArr = Console.ReadLine().ToCharArray();
            //for (int i = 0; i < charArr.Length; i++) {
            //    if (Char.IsLower(charArr[i])) {
            //        charArr[i] = Char.ToUpper(charArr[i]);
            //    }else if (Char.IsUpper(charArr[i])) {
            //        charArr[i] = Char.ToLower(charArr[i]);
            //    }
            //}
            //Console.WriteLine(string.Join("", charArr));

            // 80
            char[] result = Console.ReadLine().ToCharArray();
            for (int i = 0; i < result.Length; i++) {
                if (Char.IsAsciiLetter(result[i])) {
                    char opChar = Char.IsUpper(result[i]) ? 'A' : 'a';
                    result[i] = (char)((int)(result[i] - opChar) - 3 + opChar);
                } else {
                    result[i] = result[i];
                }
            }
            Console.WriteLine(string.Join("", result));


        }
    }
}
