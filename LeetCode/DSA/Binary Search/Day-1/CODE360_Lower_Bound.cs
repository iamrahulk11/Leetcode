using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA.Binary_Search.Day_1
{
    //Basic : Lower bound
    internal class CODE360_Lower_Bound
    {
        public static void Main(string[] args)
        {
            List<int> arr = new List<int>(){ 1, 2, 2, 3, 3, 5 };
            int target = 2;
            Console.WriteLine("Result: " + lowerBound(arr, arr.Count, target));
            Console.ReadLine();
        }

        /// <summary>
        /// LOWER BOUND : ARR[INDEX] >= TARGET
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int lowerBound(List<int> arr, int n, int x) 
        {
            int start = 0, end = n - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] >= x)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }
    }
}