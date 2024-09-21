using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
    {
        private static void Main(string[] args)
        {
            //string s = "aeiou";
            //int k = 2;
            //string s = "abciiidef";
            //int k = 3;
            //string s = "weallloveyou";
            //int k = 7;
            string s = "ibpbhixfiouhdljnjfflpapptrxgcomvnb";
            int k = 33;

            Console.WriteLine(MaxVowels(s, k));
            Console.ReadLine();
        }

        public static int MaxVowels(string s, int k)
        {
            int start = 0, end = k-1;
            int count = getVowelCount(s, start, end);
            int maxCount = count;

            start++; end++;
            while (end < s.Length)
            {
                
                if ((s[start-1] == 'a' || s[start - 1] == 'e' || s[start - 1] == 'i' || s[start - 1] == 'o' || s[start - 1] == 'u'))
                {
                    count--;
                }
                if ((s[end] == 'a' || s[end] == 'e' || s[end] == 'i' || s[end] == 'o' || s[end] == 'u'))
                {
                    count++;
                }

                maxCount = count > maxCount ? count : maxCount;
                start++;
                end++;
            }
            return maxCount;
        }

        public static int getVowelCount(string s, int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if ((s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
