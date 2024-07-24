using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Three_Consecutive_Odds
    {
        private static void Main(string[] args)
        {
            //int[] arr = { 2, 6, 4, 1 };
            //int[] arr = { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            int[] arr = { 1, 1,1 };
            int counter = 0, index = 0;            

            bool result = checkConsecutive(counter, arr, index);
            Console.WriteLine($"Result : {result}");
            Console.ReadLine();
        }

        public static bool checkConsecutive(int counter, int[] arr, int index)
        {
            foreach (var value in arr)
            {
                if (counter == 3) return true;
                if (value % 2 != 0 || value == 1) counter++;
                else counter = 0;
            }
            return false;
            //if (counter == 3) return true;
            //if (arr.Length == index) return false;

            //if (arr[index] % 2 != 0) counter++;
            //else counter = 0;

            //return checkConsecutive(counter, arr, index + 1);
        }
    }
}
