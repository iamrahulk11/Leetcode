using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Sort_an_Array
    {
        private static void Main(string[] args)
        {
            //test case 1:
            //int[] arr = { 5, 1, 1, 2, 0, 0 };

            //test case 2 :
            int[] arr = { 1, 1, -6, -4, 5, -6, 1, -4, 1 };

            int[] answer = sortArray(arr);

            foreach (int i in answer)
            {
                Console.WriteLine($"value : {i}");
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Sort an array in n log n
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] sortArray(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return nums;
            }

            int max = nums[0], min = nums[0];
            foreach (int num in nums)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            int range = max - min + 1;
            int[] count = new int[range];

            foreach (int num in nums)
            {
                count[num - min]++;
            }

            int index = 0;
            for (int i = 0; i < range; i++)
            {
                int freq = count[i];
                if (freq > 0)
                {
                    int value = i + min;
                    while (freq > 0)
                    {
                        nums[index++] = value;
                        freq--;
                    }
                }
            }

            return nums;
        }
    }
}
