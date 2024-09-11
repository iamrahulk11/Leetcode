using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Remove_Duplicates
    {
        private static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = RemoveDuplicates(arr);

            Console.WriteLine($"Result : {result}");
            Console.ReadLine();

        }
        public static int RemoveDuplicates(int[] nums)
        {
            int counter = 0;
            int secondValue = 0;
            foreach (var value in nums)
            {
                if (value == secondValue) counter++;
                secondValue = value;
            }
            return counter;
        }
    }
}
