using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Move_Zeroes
    {
        public static void Main()
        {
            int[] arr = { 0, 1, 0, 3 , 12 }; 

            MoveZeroes(arr);
            Console.ReadLine();
        }

        /// <summary>
        /// Create a index starts with 0
        /// Loop in the array and find non zeroes element and
        /// Swap them to the index created at start and increase the index by 1
        /// </summary>
        /// <param name="nums"></param>
        public static void MoveZeroes(int[] nums)
        {
            int IndexOfElementZero = 0;
            for (int value = 0; value < nums.Length; value++)
            {
                if (nums[value] != 0)
                {
                    int temp = nums[value];
                    nums[value] = nums[IndexOfElementZero];
                    nums[IndexOfElementZero] = temp;
                    IndexOfElementZero++;
                }
            }
            foreach (int value in nums)
            {
                Console.WriteLine(value);
            }
        }
    }
}
