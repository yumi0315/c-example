using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Ex03
    {
        static void Main()
        {
            // 콘솔로부터 입력받기
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //int myInt = int.Parse(input);
            //Console.WriteLine(myInt);

            // 연습문제2
            // 1. 콘솔로부터 정수 1개를 입력받고,
            // 그 수에 10을 곱한 수를 출력하시오.
            Console.Write("정수 입력: ");
            string input = Console.ReadLine();
            int myInt = int.Parse(input) * 10;
            Console.WriteLine(myInt);

            // 2. 콘솔로부터 정수 1개를 입력받고 (1~100까지 중 하나)
            // 그 수가 짝수이면 "짝수", 홀수이면 "홀수"라고 출력하시오.
            // 힌트) %연산자 이용
            Console.Write("정수 입력: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputNum%2 == 0 ? "짝수":"홀수");
            
            // 3. 문자열 두개 입력받아서 합쳐서 출력
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(input1 + input2);

            // 문자열 보간
            Console.WriteLine($"{input1}, {myInt}");

            // 4. 콘솔로부터 정수 1개를 입력받고
            // 문자열 보간을 이용하여 출력하시오.
            // 입력예) 20
            // 출력예) 입력된 숫자는 20입니다.
            Console.Write("정수 입력: ");
            string input3 = Console.ReadLine();

            Console.WriteLine($"입력된 숫자는 {input3}입니다.");
        }
    }
}
