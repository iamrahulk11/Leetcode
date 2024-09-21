using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Count_the_Number_of_Consistent_Strings
    {
        private static void Main(string[] args)
        {
            ////test case : 1
            //string allowed = "ab";
            //string[] words = { "ad", "bd", "aaab", "baa", "badab" };
            
            ////test case : 2
            string allowed = "abc";
            string[] words = { "a", "b", "c", "ab", "ac", "bc", "abc" };

            Console.WriteLine("Result : "+ CountConsistentStrings(allowed, words));

            Console.ReadLine();
        }
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                count = checkString(allowed, words[i]) ? count+1 : count;
            }
            return count;
        }
        public static bool checkString(string allowed, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!allowed.Contains(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}