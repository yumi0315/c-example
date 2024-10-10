using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class Ex04 {
        static void Main() {

            //연습문제3
            //1. 정수형 변수 하나를 선언하고 123으로 초기화한다.
            //  백의 자릿수와 십의 자릿수, 일의 자릿수를 구하여 출력하시오.
            // 출력예) 백의 자릿수: 1
            //        십의 자릿수: 2
            //        일의 자릿수: 3
            //2. 콘솔로부터 정수 2개를 입력받고
            // 더 큰 수를 출력하시오.
            // 입력예) 10
            //        20
            // 출력예) 20
            //3. 콘솔로부터 10자미만의 문자열을 입력받고,
            // null이 아니라면(null 조건부 연산자 사용), 그 문자열의 길이를 출력하시오.
            // string str; str.Length 문자열의 길이
            //4. string input = null 로 선언하고
            // input이 null이라면 기본값 "null값입니다."를 출력하는 코드를 작성하시오.
            // null 병합 연산자 사용

            int num = 123;
            string strnum = num.ToString();
            Console.WriteLine($"백의 자릿수: {strnum[0]}");
            Console.WriteLine($"십의 자릿수: {strnum[1]}");
            Console.WriteLine($"일의 자릿수: {strnum[2]}");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 > num2 ? num1 : num2);

            string? input = Console.ReadLine();
            Console.WriteLine(input?.Length);

            input = null;
            Console.WriteLine($"{input ?? "null"}값 입니다.");


        }
    }
}
