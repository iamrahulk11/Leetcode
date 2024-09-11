using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Second_Largest_Element_Array
    {
        public static void Main(string[] args)
        {
            int[] nums = { 12, 35, 1, 10, 34, 1 };
            int second_largest = 0;
            int first_largest = 0;

            foreach (int i in nums)
            {
                if (first_largest < i) { first_largest = i; }

            }
        }
    }
}
