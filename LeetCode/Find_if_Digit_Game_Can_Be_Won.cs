using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Find_if_Digit_Game_Can_Be_Won
    {
        private static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 10 };

            Console.WriteLine("Alice can win : "+CanAliceWin(nums));
          
            Console.ReadLine();
        }
        public static bool CanAliceWin(int[] nums)
        {
            int sumOfSingleDigits = 0, sumOfDoubleDigits = 0;
            foreach (var val in nums)
            {
                if (val < 10)
                {
                    sumOfSingleDigits += val;
                }
                if (val >= 10)
                {
                    sumOfDoubleDigits += val;
                }
            }
            if (sumOfDoubleDigits == sumOfSingleDigits)
            {
                return false;
            }
            return true;
        }
    }
}
