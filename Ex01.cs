using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Ex01
    {
        // CLI : hwp.exe a.hwp b.hwp
        // ["a.hwp", "b.hwp"]
        //      : npm install express
        static void Main(string[] args)
        {
            // 정수형 변수 한개 선언
            int num = 10;
            Console.WriteLine(num);

            // 정수형 상수 선언
            // 상수 : 한번 값이 정해지면 바꿀 수 없는 변수
            const double PI = 3.141592;
            Console.WriteLine(PI);
            // PI = 4.14; // 상수에 값을 재할당하면 오류

            //논리형(부울형)
            bool myBool = true;
            // 정수형 4바이트
            int myInt = 100;
            // 정수형 8바이트
            long myLong1 = 200; // int 200을 만들어서 long형 변환됨.
            long myLong2 = 300L;  // long 300을 만들어서 값이 복사됨.
            // 실수형 4바이트
            float myFloat = 3.14f; // 리터럴 뒤에 f를 꼭 써야됨.
            // 실수형 8바이트
            double myDouble = 4.25; // 실수는 기본이 double 타입
            // 문자열(쌍따옴표만)
            string myString = "대한민국";
        }
    }
}
