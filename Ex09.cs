using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples {
    internal class Ex09 {
        static void Main(string[] args) {
            Console.WriteLine(circumference(10));
            Console.WriteLine(getMaxInt(10,30,20));
            Console.WriteLine(compressString("aaabbcccc"));
            Console.WriteLine(FindMin([1,2,3]));
            Console.WriteLine(string.Join(" ", MergeAndSort([6, 7, 8, 9], [3, 2, 1])));
            Console.WriteLine(DecryptCaesarCipher("Khoor Zruog!"));
        }

        static double circumference(int r) {
            return r * 2 * 3.14;
        }

        static int getMaxInt(int a, int b, int c) {
            int[] arr = { a, b, c };
            return arr.Max();
        }

        static string compressString(string input) {
            //Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            //foreach (char c in input) {
            //    if (myDictionary.ContainsKey(c)) {
            //        myDictionary[c]++;
            //    } else {
            //        myDictionary[c] = 1;
            //    }
            //}
            //StringBuilder result = new StringBuilder();
            //foreach (var pair in myDictionary) {
            //    result.Append(pair.Key);
            //    result.Append(pair.Value);
            //}
            //return result.ToString();
            // GroupBy 컬렉션의 요소를 특정 기준에 따라 그룹화
            // Select로 key랑 count랑 합침
            return string.Concat(input.GroupBy(c => c)
                              .Select(g => $"{g.Key}{g.Count()}"));
        }
        static int FindMin(int[] array) {
            return array.Min();
        }
        static int[] MergeAndSort(int[] array1, int[] array2) {
            int[] result = array1.Concat(array2).ToArray();
            Array.Sort(result);
            return result;
        }
        static string DecryptCaesarCipher(string input) {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++) {
                if ((result[i] >= 'a' && result[i] <= 'z') || (result[i] >= 'A' && result[i] <= 'Z')) {
                    result[i] = (char)((int)(result[i] - (result[i] >= 'a' ? 'a' : 'A')) - 3 + (result[i] >= 'a' ? 'a' : 'A'));
                } else {
                    result[i] = result[i];
                }
            }
            return string.Join("", result);
        }

    }
}
