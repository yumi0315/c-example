using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class EX41_50 {
        static void Main(string[] args) {
            // 41
            //int num = Convert.ToInt32(Console.ReadLine());
            //if ((num >= 30 && num <= 40) || (num >= 60 && num <= 70)) {
            //    Console.WriteLine("win");
            //} else {
            //    Console.WriteLine("lose");
            //}

            // 42
            //int num = Convert.ToInt32(Console.ReadLine());
            //if ((num >= 50 && num <= 70) || (num % 6 == 0 )) {
            //    Console.WriteLine("win");
            //} else {
            //    Console.WriteLine("lose");
            //}

            // 43
            //string[,] eksdnl = { { "", "십", "백", "천" },{ "만" ,"억", "경", "해"} };
            //string[] tntwk = { "", "일", "이", "삼", "사", "오", "육", "칠", "팔", "구" };
            //string num = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < num.Length; i++) {
            //    int temp = (int)(num[i]-'0'); count++;
            //    if(temp != 0) {
            //        Console.Write($"{tntwk[temp]}{eksdnl[0, (num.Length - count) % 4]}");
            //    }
            //    if (count != num.Length && (num.Length - count) % 4 == 0 ) {
            //        Console.Write(eksdnl[1, (num.Length - count) / 4 - 1]);
            //    }
            //}

            // 44
            //int day = Convert.ToInt32(Console.ReadLine());
            //int[] work = { 1, 3, 5, 7 };
            //if(Array.Exists(work,x => x == day)) {
            //    Console.WriteLine("oh my god");
            //} else {
            //    Console.WriteLine("enjoy");
            //}

            // 45
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int d = b * b - 4 * a * c;
            //if (d < 0) {
            //    Console.WriteLine("실근이 없습니다");
            //} else if (d == 0) {
            //    Console.WriteLine($"방정식의 해는 {-b / (2 * a):0.00}");
            //} else {
            //    Console.WriteLine($"방정식의 해는 {(-b + Math.Sqrt(d)) / (2 * a):0.00}");
            //    Console.WriteLine($"방정식의 해는 {(-b - Math.Sqrt(d)) / (2 * a):0.00}");
            //}

            // 46
            //int[] num = new int[3];
            //for (int i = 0; i < num.Length; i++) {
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < num.Length; i++) {
            //    if (num[i] <= 170) {
            //        Console.WriteLine("CRASH");
            //    } else {
            //        Console.WriteLine("PASS");
            //    }
            //}

            // 47
            //int year = Convert.ToInt32(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
            //    Console.WriteLine("yes");
            //} else {
            //    Console.WriteLine("no");
            //}

            // 48
            //string frontUnique = Console.ReadLine();
            //int year = 2012;
            //int birthYear = (frontUnique[3] == '1' ? 1900 : 2000) + int.Parse(frontUnique.Substring(0,2));
            //Console.WriteLine(year - birthYear + 1);

            // 49
            //int hour = Convert.ToInt32(Console.ReadLine());
            //int minute = Convert.ToInt32(Console.ReadLine());

            //if (minute < 30) {
            //    hour = (hour - 1 + 12) % 12;
            //}
            //minute = (minute - 30 + 60) % 60;
            //Console.WriteLine($"{hour} {minute}");

            // 50
            //double bmi = Convert.ToDouble(Console.ReadLine());
            //if(bmi < 18.5) {
            //    Console.WriteLine("저체중");
            //} else if( bmi <= 23 ) {
            //    Console.WriteLine("정상체중");
            //} else {
            //    Console.WriteLine("과체중");
            //}

        }
    }
}
