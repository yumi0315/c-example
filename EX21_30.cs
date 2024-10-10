using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX21_30 {
        static void Main(string[] args) {
            // 21
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a * Math.Pow(2,b));

            // 22
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a > b ? 1 : 0);

            // 23
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a == b ? 1 : 0);

            // 24
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a < b ? 1 : 0);

            // 25
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a != b ? 1 : 0);

            // 26
            //bool inputBool = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(!inputBool);

            // 27
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a > b ? a : b);

            // 28
            //int[] arr = new int[3];
            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i]= Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i] % 2 == 0) {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            // 29
            //int[] arr = new int[3];
            //for (int i = 0; i < arr.Length; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i] % 2 == 0) {
            //        Console.WriteLine("even");
            //    } else {
            //        Console.WriteLine("odd");
            //    }
            //}

            // 30
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num > 0 ? "plus":"minus");
            Console.WriteLine(num % 2 == 0 ? "even" : "odd");

        }
    }
}
