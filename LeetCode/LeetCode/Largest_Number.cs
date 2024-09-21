using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Largest_Number
    {
        private static void Main(string[] args)
        {
            //int[] nums = { 3, 30, 34, 5, 9 };
            //int[] nums = { 10, 2 };
            //int[] nums = { 432, 43243 };
            int[] nums = { 111311, 1113 };

            Console.WriteLine(LargestNumber(nums));
            Console.ReadLine();
        }
        public static string LargestNumber(int[] nums)
        {
            string result = string.Empty;
            int length = nums.Length;
            int maxNumber = 0;

            foreach(int num in nums)
            {
                result = $"{result}{num.ToString()}";
            }
            string tempNumber = result;

            for (int i=0;i<nums.Length; i++)
            {                
                
            }
            
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result = $"{result}{nums[i].ToString()}";
            }
            return result;
        }
        public static int tempNumber(int[] nums, string maxNumber)
        {
            int number = 0;
            string res = "0";

            for (int i = 0; i < nums.Length; i++)
            {

            }

            return Convert.ToInt32((res));
        }
    }
}
