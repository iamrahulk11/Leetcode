using System.Diagnostics.CodeAnalysis;

namespace LeetCode
{
    internal class Kth_Largest_Element_Array
    {
        //Leetcode Solution
        //public class Solution
        //{
        //    public int FindKthLargest(int[] nums, int k)
        //    {
        //        PriorityQueue<int, int> Pvalues = new();
        //        int cal = ints.Length - k;
        //        foreach (int i in ints)
        //        {
        //            Pvalues.Enqueue(i, i);
        //        }
        //        for (int i = 0; i < cal; i++)
        //        {
        //            Pvalues.Dequeue();
        //        }
        //        return Pvalues.Peek();
        //    }
        //}

        /// <summary>
        /// Using priority queue to set the array in sorted order(element with their priority),
        /// then removing number of element till (nums length-k)-1
        /// from the Priority queue.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            PriorityQueue<int, int> Pvalues = new();

            int[] ints = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k = 4;
            int cal = ints.Length - k;
            foreach (int i in ints)
            {
                Pvalues.Enqueue(i, i);
            }

            for (int i = 0; i < cal; i++)
            {
                Pvalues.Dequeue();
            }

            var result = Pvalues.Peek();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}