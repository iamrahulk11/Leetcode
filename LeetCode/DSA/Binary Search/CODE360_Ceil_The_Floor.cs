using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA.Binary_Search
{
    internal class CODE360_Ceil_The_Floor
    {
        public static void Main(string[] args)
        {
            int n = 10, target = 14;
            int[] nums = { 6, 6, 7, 12, 16, 18, 19, 22, 23, 30 };

            Console.WriteLine("Result: " + ceil(nums, n, target));
            Console.ReadLine();
        }

        public static (int,int) ceil(int[] a, int n, int x)
        {
            int start = 0, end = n - 1;
            int answer = -1;
            (int, int) answerPair;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (a[mid] <= x)
                {
                    answer = a[mid];
                    start = mid + 1;                    
                }
                else
                {
                    end = mid - 1;
                }
            }
            answerPair.Item1 = answer;

            start = 0; end = n - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (a[mid] >= x)
                {
                    answer = a[mid];
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            answerPair.Item2 = answer;
            return answerPair;
        }
    }
}
