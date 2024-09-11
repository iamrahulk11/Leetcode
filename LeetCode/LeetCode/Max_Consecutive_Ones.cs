using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Max_Consecutive_Ones
    {
        public static void Main()
        {
            int[] arr = { 1, 1, 0, 1, 1, 1 };

            Console.WriteLine($"Max consecutive one is : {FindMaxConsecutiveOnes(arr)}");
            Console.ReadLine();
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0, max = 0;
            for (int value = 0; value < nums.Length; value++)
            {
                if (nums[value] == 0)
                {
                    max = max < count ? count : max;
                    count = 0;
                    continue;
                }
                count++;
            }
            if (nums[nums.Length - 1] == 1)
            {
                max = max < count ? count : max;
            }
            return max;
        }
    }
}
