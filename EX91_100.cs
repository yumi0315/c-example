using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examples {
    internal class EX91_100 {
        static void Main(string[] args) {
            // 91
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];

            //for(int i = 0; i < arr.Length; i++) 
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < arr.Length; i++) {
            //    for(int j = 0; j < arr.Length; j++) {
            //        Console.Write(arr[(i+j)%num] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // 92
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            //Thread.Sleep(10000);
            //Console.Clear();
            //Console.Write("k 입력: ");
            //int k = Convert.ToInt32(Console.ReadLine());

            //Console.Write("k번째 숫자: ");
            //int ans = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"k번째 숫자: {arr[k - 1]} \n입력한 숫자: {ans}\n{(arr[k-1] == ans ? "정답" : "틀렸습니다")}");

            // 93
            //string[] arr = Console.ReadLine().Split(" ");
            //Thread.Sleep(10000);
            //Console.Clear();
            //Console.Write("k 입력: ");
            //int k = Convert.ToInt32(Console.ReadLine());

            //Console.Write("k번째 단어: ");
            //string ans = Console.ReadLine();

            //Console.WriteLine($"k번째 숫자: {arr[k - 1]} \n입력한 숫자: {ans}\n{(arr[k-1] == ans ? "정답" : "틀렸습니다")}");

            // 94
            //string input = Console.ReadLine();
            //Console.WriteLine(string.Concat(input.GroupBy(c => c)
            //                  .Select(g => $"{g.Count()} ")));

            // 95
            //string input = Console.ReadLine();
            //Console.WriteLine(string.Concat(input.Where(char.IsLetter)
            //                                     .GroupBy(c => c)
            //                                     .Select(g => $"{g.Key}:{g.Count()}\n")));
            //Console.WriteLine(string.Concat(input.Where(char.IsLetter).Select(c =>$"{c}:{input.Count(x => x == c)}\n")));

            // 96
            //int num = Convert.ToInt32(Console.ReadLine());
            //Dictionary<string,int> dic= new Dictionary<string, int>();

            //for (int i = 0; i < num; i++) {
            //    dic.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            //}
            //dic = dic.OrderBy(item => item.Value).ToDictionary(x => x.Key, x => x.Value);
            //Console.WriteLine(dic.Keys.ElementAt(2));

            // 97
            //int num = Convert.ToInt32(Console.ReadLine());
            //int row = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[num];

            //for(int i = 0; i < num; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //for(int i = 0; i < num; i++) {
            //    Console.Write(arr[i] + " ");
            //    if((i+1)%row == 0) {
            //        Console.WriteLine();
            //    }
            //}

            // 98
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[,] arr = new int[10, 10]; 
            //for(int i = 0; i < num; i++) {
            //    Console.Write("X:");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Y:");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    arr[x-1, y-1] = 1;
            //}
            //for (int i = 0; i < 10; i++) {
            //    for (int j = 0; j < 10; j++) {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // 99
            //int num = Convert.ToInt32(Console.ReadLine());
            //printScore(num);

            // 100
            Random rand = new Random();
            int num = rand.Next(1, 100);
            
            Console.WriteLine("번호를 입력하세요.");
            int input = 0;

            while (num != input) {
                input = Convert.ToInt32(Console.ReadLine());
                if (num > input) {
                    Console.WriteLine("번호가 정답보다 큽니다.");
                } else if (num < input) {
                    Console.WriteLine("번호가 정답보다 작습니다.");
                } 
            }
            Console.WriteLine("정답입니다.");
            
        }

        static void printScore(int num) {
            char[] arr = ['E','E','E','E','E','E','D','C','B','A','A'];
            Console.WriteLine(arr[num / 10]);
        }
    }
}
