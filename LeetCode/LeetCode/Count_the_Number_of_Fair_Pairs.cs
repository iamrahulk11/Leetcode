using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Count_the_Number_of_Fair_Pairs
    {
        public static void Main(string[] args)
        {
            int[] nums = { 0, 1, 7, 4, 4, 5 };
            int lower = 3; int upper = 6;

            Console.WriteLine(CountFairPairs(nums,lower,upper));
            Console.ReadLine();
        }

        public static long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);
            long count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                long upperCount = CountUpperBound(nums, i+1, nums.Length-1, upper, nums[i], i);
                long lowerCount = CountLowerBound(nums, i + 1, nums.Length-1, lower, nums[i], i);

                if (upperCount == 0 && lowerCount == 0)
                    break;

                count += (upperCount - lowerCount);
            }
            return count;
        }

        public static long CountUpperBound(int[] nums, int start, int end, int upper, int currentValue, int currentIndex)
        {
            long count = 0;
            while (start<=end)
            {
                int mid = (start+end)/2;

                if ((currentValue + nums[mid]) <= upper)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            count = end - currentIndex;

            return count;
        }
        public static long CountLowerBound(int[] nums, int start, int end, int lower, int currentValue, int currentIndex)
        {
            long count = 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if ((currentValue + nums[mid]) >= lower)
                {
                    end = mid - 1;
                    count = mid;
                }
                else 
                { 
                    start = mid + 1; 
                }
            }
            count = end - currentIndex;

            return count;
        }
    }
}
