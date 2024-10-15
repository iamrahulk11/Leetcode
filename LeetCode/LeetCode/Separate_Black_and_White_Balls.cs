using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Separate_Black_and_White_Balls
    {
        public static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine(MinimumSteps(s));
        }
        public static long MinimumSteps(string s)
        {
            long countZero = 0;
            long steps = 0;
            for (int i = s.Length - 1; i >= 0; i++)
            {
                if (s[i].ToString() == "0")
                {
                    countZero++;
                }
                if (s[i].ToString() == "1")
                {
                    steps = steps + countZero;
                }
            }
            return steps;
        }
    }
}
