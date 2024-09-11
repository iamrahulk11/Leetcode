using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Happy_Number
    {
        //Floyd’s Cycle Detection Algorithm
        public static void Main()
        {
            //int n = 2;
            int n = 10;
            Console.WriteLine($"Is Happy Number : {IsHappy(n)}");

            Console.ReadLine();
        }

        /// <summary>
        /// Check the sum of square of individual digits reaches 1 or in a cycle
        /// Used Floyd algorithm to check the cycle
        /// Running slow and fast indexing to check either they matches the same number or reaches 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsHappy(int n)
        {
            //Floyd’s Cycle Detection Algorithm
            if (n == 1 || n == 7 || n == 10) return true;
            if (n == 2) return false;
            int slow = squareSum(n),
            fast = squareSum(slow);

            while (slow != fast)
            {
                slow = squareSum(slow);
                fast = squareSum(squareSum(fast));
                if (fast == 1 || fast == 7 || fast == 10) return true;
            }
            if (fast == 1 || fast == 7 || fast == 10) return true;
            return false;
        }

        //This function returns the sum of square of individual digits
        public static int squareSum(int n)
        {
            int sum = 0, tmp;
            while (n > 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }
    }
}
