using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class Ex05 {
        static void Main(string[] args) {
            //조건문 if문 swith문
            //1.단일 if문
            //패턴 
            //if( 조건식 ) { //비교,논리연산자로 이루어진 식
            //  true일때만 수행되는 수행문
            //}
            if (true) {
                Console.WriteLine("조건식이 true임");
            }
            if (10 == 20) { //조건식이 false이므로 실행되지 않음.
                Console.WriteLine("10과 20은 같음");
            }

            //2.if else문
            //패턴
            //if( 조건식 ) {
            //   true일 때 수행
            //}else{
            //   false일 때 수행
            //}
            if (10 == 20) {
                Console.WriteLine("true임");
            } else {
                Console.WriteLine("false임");
            }

            //3.if else if문
            int num = 30;
            if (num == 10) {
                Console.WriteLine("10입니다.");
            } else if (num == 20) {
                Console.WriteLine("20입니다.");
            } else if (num == 30) {
                Console.WriteLine("30입니다.");
            } else {
                Console.WriteLine("그외의 수입니다.");
            }

            //4.중첩 if문 - if문 안에 if문
            if (true) {
                if (true) {

                } else {

                }
            }

            //랜덤한 정수 생성하기
            //Random 클래스 : 랜덤한 수를 생성해주는 클래스
            //rand : 클래스로부터 생성된 객체
            //new : 객체를 생성하는 예약어
            //Random() : 클래스이름과 동일한 생성자함수
            //클래스 안에는 변수와 메소드가 있다!
            Random rand = new Random();
            int randNum = rand.Next(1, 100); //1부터 100사이의 랜덤한 정수 발생!
            Console.WriteLine(randNum);

            //연습문제4
            //1. 철수와 영희가 각각 주사위를 2번씩 던져서,
            // 주사위의 수의 합이 더 큰 사람이 승리하게 된다.
            // 누가 승리하는지 출력하시오.
            // 입력예) 주사위값 4개
            // 출력예) 영희 승! or 철수 승!
            int cjftn = rand.Next(1, 6) + rand.Next(1, 6);
            int dudgml = rand.Next(1, 6) + rand.Next(1, 6);
            Console.WriteLine(cjftn + " " + dudgml);
            Console.WriteLine(cjftn >= dudgml ?
                                        cjftn==dudgml ? "무승부" : "철수 승" 
                                        : "영희 승"  );

            //2. 랜덤한 정수 (0부터 9사이)를 2개 뽑아서
            // 첫번째 정수는 십의 자리로, 두번째 정수는 일의 자리로 생성하여
            // 출력하시오.
            // 입력예) 랜덤한 정수 2개 1과 3
            // 출력계) 13
            int a = rand.Next(0, 9);
            int b = rand.Next(0, 9);
            Console.WriteLine(a + "" + b);

            //3. 1부터 100사이의 랜덤한 정수를 하나 발생시키고
            // 90점이상이면 "A"
            // 80점이상이면 "B"
            // 70점이상이면 "C"
            // 60점이상이면 "D"
            // 그외의 수이면 "E" 라고 출력하시오.
            // 입력예) 88
            // 출력예) B
            char[] arr = { 'E', 'E', 'E', 'E', 'E', 'E', 'D', 'C', 'B', 'A', 'A' };
            int score = rand.Next(1, 100);
            Console.WriteLine(arr[(int)score/10]);

            //4. 철수와 영희가 교대로 주사위를 계속 던져(무한 루프)
            // 같은 주사위의 값이 먼저 나온 사람이 승리하게 된다.
            // 누가 먼저 승리하는지 출력하시오.
            // 출력예) 철수 4
            //         영희 5
            //         철수 4
            //         철수 승!
            cjftn = 0;
            dudgml = 0;
            string win = "";
            while (true) {
                int temp = rand.Next(1, 6);
                if(cjftn == temp) {
                    win = "철수";
                    break;
                }
                cjftn = temp;
                Console.WriteLine($"철수 {cjftn}");
                
                temp = rand.Next(1, 6);
                if( dudgml == temp ) {
                    win = "영희";
                    break;
                }
                dudgml = temp;
                Console.WriteLine($"영희 {dudgml}");
            }
            Console.WriteLine($"{win} 승");

            //5. 100제 - 34번
            // 0부터 9사이의 정수값을 차례로 3개 발생시키고
            // 그 값을 반대로 출력하시오.(ArrayList나 배열 사용)
            // 배열: int[] student = new int[6];
            // 리스트: ArrayList<int> list = new ArrayList(); list.add(3);
            // 입력예) 3 6 8
            // 출력예) 8 6 3
            int[] randomNums = new int[3];
            for (int i = 0; i < randomNums.Length; i++) {
                randomNums[i] = rand.Next(0,9);
            }
            Array.Reverse(randomNums);
            for (int i = 0; i < randomNums.Length; i++) {
                Console.Write(randomNums[i]);
            }

        }
    }
}
