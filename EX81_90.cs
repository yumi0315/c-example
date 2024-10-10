using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX81_90 {
        static void Main(string[] args) {
            // 81
            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());

            // 82
            //string[] dan = Console.ReadLine().Split(" ");
            //for (int i = int.Parse(dan[0]); i <= int.Parse(dan[1]); i++) {
            //    for (int j = 1; j <= 9; j++) {
            //        Console.WriteLine($"{i}*{j}={i*j}");
            //    }
            //}

            // 83
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++) {
            //    for (int j = 0; j <= i; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // 84
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++) {
            //    for (int j = 0; j < num-i; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // 85
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++) {
            //    for (int j = 0; j < num; j++) {
            //        if(i > j) {
            //            Console.Write(" ");
            //        } else {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // 86
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = num/2 ; i < num ; i++) {
            //    for (int j = 0 ; j <= i ; j++) {
            //        if (num -1 - i > j) {
            //            Console.Write(" ");
            //        } else {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // 87
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < num; i++) {
            //    for(int j = 0; j < num; j++) {
            //        if ( i != 0 && i != num-1 && j != 0 && j != num-1 ) {
            //            Console.Write(" ");
            //        } else {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // 88
            //int num = Convert.ToInt32(Console.ReadLine());
            //int copyNum = num;
            //int result = 0;
            //for (int i = 1; i <= num; i++) {
            //    result += i * copyNum--;
            //}
            //Console.WriteLine(result);

            // 89
            //int num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = (num > 6 ? num-6 : 1); i <= 6; i++) {
            //    for (int j = 1; j <= 6; j++) {
            //        if (num == i + j) {
            //            Console.WriteLine($"{i} {j}");
            //        }
            //    }
            //}

            // 90
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Join(" ", arr.Reverse()) );

        }
    }
}
