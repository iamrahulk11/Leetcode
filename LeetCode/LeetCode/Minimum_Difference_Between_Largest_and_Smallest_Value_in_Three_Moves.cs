using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Minimum_Difference_Between_Largest_and_Smallest_Value_in_Three_Moves
    {
        public static void Main()
        {

            int[] nums = { 1, 5, 0, 10, 14 };

            Console.WriteLine(MinDifference(nums));

            Console.ReadLine();

        }
        public static int MinDifference(int[] nums)
        {
            if (nums.Length < 5) return 0;

            (int, int) MinMax = getMaximumMinimum(nums);

            if (MinMax.Item1 - MinMax.Item2 == 1)
            {
                return 1;
            }

            return MinMax.Item1 - MinMax.Item2;
        }

        public static (int, int) getMaximumMinimum(int[] nums)
        {
            int miniMum = int.MaxValue;
            List<int> MAXList = new();
            int maxMinimum = 0;
            foreach (int num in nums)
            {
                if (miniMum > num) miniMum = num;
            }

            for (int i = 0; i < 4; i++)
            {
                foreach (int num in nums)
                {
                    if (MAXList.Contains(num)) continue;
                    if (maxMinimum < num) maxMinimum = num;
                }
                MAXList.Add(maxMinimum);
                maxMinimum = 0;
            }

            maxMinimum = int.MaxValue;

            foreach (int num in MAXList)
            {
                if (maxMinimum > num) maxMinimum = num;
            }

            return (miniMum, maxMinimum);
        }
    }
}
