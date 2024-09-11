using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Sum_of_Digits_of_String_After_Convert
    {
        public static void Main()
        {
            string testCase = "iiii";
            int k = 1;
            Console.WriteLine(GetLucky(testCase, k));

            Console.ReadLine();
        }
        public static int GetLucky(string s, int k)
        {
            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            convertAlphabets(alphabets, s, k);

            return 0;
        }

        private static string convertAlphabets(char[] alphabets, string givenValue, int k)
        {
            string conversion = "";

            for (int i = 0; i < givenValue.Length; i++)
            {
                conversion += getIndex(givenValue[i], alphabets);
            }

            return GetSum(k, conversion);

        }

        private static string GetSum(int transform, string convertedString)
        {
            int sum = 0;
            string tempAnswer = convertedString;

            for (int k = 0; k < transform; k++)
            {
                sum = 0;
                for (int i = 0; i < tempAnswer.Length; i++)
                {
                    sum += tempAnswer[i] - '0';
                }
                tempAnswer = sum.ToString();
            }

            return tempAnswer;
        }

        private static string getIndex(char s, char[] alphabets)
        {
            string value = "";
            for (int i = 0; i < alphabets.Length; i++)
            {
                if (s == alphabets[i])
                {
                    value = (i + 1).ToString();
                }
            }
            return value;
        }
    }
}
