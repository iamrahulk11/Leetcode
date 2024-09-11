using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    ///LEETCODE SOLUTION
    //public int[] Intersect(int[] nums1, int[] nums2)
    //{
    //    List<int> list = new List<int>();
    //    int maxNumber = GetMaxElement(nums1, nums2);
    //    int[] hashArr = new int[maxNumber + 1];

    //    foreach (int num in nums1)
    //    {
    //        hashArr[num]++;
    //    }

    //    foreach (int num in nums2)
    //    {
    //        if (hashArr[num] == 0)
    //        {
    //            continue;
    //        }
    //        list.Add(num);
    //        hashArr[num]--;
    //    }

    //    return list.ToArray();
    //}

    ////get max number
    //public static int GetMaxElement(int[] num1, int[] num2)
    //{
    //    int maxNumber = 0;
    //    foreach (int i in num1)
    //    {
    //        if (maxNumber < i) maxNumber = i;
    //    }
    //    foreach (int i in num2)
    //    {
    //        if (maxNumber < i) maxNumber = i;
    //    }
    //    return maxNumber;
    //}

    internal class Intersection_of_Two_Arrays_II
    {
        private static void Main(string[] args)
        {
            ////Test case 1
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };

            ////Test case 2
            //int[] nums1 = { 3, 1, 2 };
            //int[] nums2 = { 1, 1 };

            ////Test case 3
            //int[] nums1 = { 4, 9, 5 };
            //int[] nums2 = { 9, 4, 9, 8, 4 };

            List<int> list = new List<int>();
            int maxNumber = GetMaxElement(nums1, nums2);
            int[] hashArr = new int[maxNumber + 1];

            foreach (int num in nums1)
            {
                hashArr[num]++;
            }

            foreach (int num in nums2)
            {
                if (hashArr[num] == 0) continue;
                list.Add(num);
                hashArr[num]--;
            }

            Console.ReadLine();

        }

        //get max number
        public static int GetMaxElement(int[] num1, int[] num2)
        {
            int maxNumber = 0;
            foreach (int i in num1)
            {
                if (maxNumber < i) maxNumber = i;
            }
            foreach (int i in num2)
            {
                if (maxNumber < i) maxNumber = i;
            }
            return maxNumber;
        }
    }
}
