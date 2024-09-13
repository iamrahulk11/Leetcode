using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA.Binary_Search
{
    internal class LC33_Search_in_Rotated_Sorted_Array
    {
        public static void Main(string[] args)
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;

            Console.WriteLine("Result : " + Search(nums, target));

            Console.ReadLine();
        }
        public static int Search(int[] nums, int target)
        {
            if (nums[0] == target)
            {
                return 0;
            }
            if (nums[nums.Length - 1] == target)
            {
                return nums.Length - 1;
            }

            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                if (target == nums[start])
                {
                    return start;
                }
                else if (target == nums[end])
                {
                    return end;
                }
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] >= nums[start])
                {
                    if (nums[mid] >= target && nums[start] <= target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] <= target && nums[end] >= target)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
