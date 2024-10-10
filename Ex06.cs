using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class Ex06 {
        static void Main(string[] args) {
            //반복문 for문 while문
            //패턴
            //for( 초기화; 조건식; 증감문 ){
            //   수행문;
            //}
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i);
            }

            //중괄호 생략하는 경우 - 수행문이 한줄일때만
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);

            if (10 < 20)
                Console.WriteLine("10<20");

            //연습문제 5
            //1. 반복변수 i를 1부터 100까지 출력하시오.
            for(int i = 1; i <= 100; i++) {
                Console.WriteLine(i);
            }

            //2. 반복변수 i를 1부터 100사이의 짝수만 출력하시오.
            for (int i = 1; i <= 100; i++) {
                if(i%2==0) Console.WriteLine(i);
            }

            //3. 10부터 -10까지 출력하시오.
            for (int i = 10; i >= -10; i--) {
                Console.WriteLine(i);
            }

            //4. 1부터 100사이의 수 중에서 3이나 6이나 9가 포함된 수만 출력하시오.
            // 출력예) 3, 6, 9, ... 3, 33 ... 99
            for (int i = 1; i <= 100; i++) {
                if (Array.Exists(i.ToString().ToCharArray(), x => x=='3' || x=='6' || x=='9' )) Console.WriteLine(i);
            }

            //5. 1부터 100사이의 2의 배수이거나 3의 배수인 수의 갯수를 출력하시오.
            int count = 0;
            for (int i = 1; i <= 100; i++) {
                if (i % 2 == 0 || i % 3 == 0 ) count++;
            }
            Console.WriteLine(count);

            //6. 10의 약수의 갯수와 그 약수를 출력하시오.
            // 약수란 나누어 떨어지는 수
            // 출력예) 10의 약수는 1 2 5 10 
            int num = 10;
            //List<int> lst = new List<int>();
            //for(int i = 1; i <= num; i++) {
            //    if(num % i == 0) {
            //        lst.Add(i);
            //    }
            //}
            SortedSet<int> list = new SortedSet<int>();
            for (int i = 1; i <= Math.Sqrt(num); i++) {
                if (num % i == 0) {
                    list.Add(num / i);
                    list.Add(i);
                }
            }
            Console.WriteLine($"10의 약수는 {string.Join(" ", list)}");

            //7. 2부터 100사이의 랜덤한 정수를 발생시키고,
            // 그 수가 소수인지 아닌지 판별하시오.
            // 소수는 약수의 갯수가 2개인 정수이다.
            // 출력예) 7은 소수입니다.
            //        10은 소수가 아닙니다.
            Random rand = new Random();
            int number = rand.Next(2, 100);
            string str = "소수입니다.";
            SortedSet<int> list2 = new SortedSet<int>();
            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) {
                    str = "소수가 아닙니다.";
                    break;
                }
            }
            Console.WriteLine($"{number}은 {str}");

        }
    }
}
