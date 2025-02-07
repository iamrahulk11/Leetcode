using System.Collections.Generic;

namespace LeetCode
{
    internal class Longest_subarray_absolute_difference_less_than_or_equal_to_K
    {        
        public static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5 };
            int k = 2;
            //printOneToN(1, 10);
            ReverseArray(arr);
            foreach(int v in arr)
            {
                Console.Write(v + " ");
            }
            //int maxLength = computeLongestSubarray(arr, k);
            //Console.WriteLine(maxLength);
            Console.ReadLine();
        }
        public static void printOneToN(int start, int N)
        {
            if(start == N + 1)
            {
                return;
            }
            Console.Write(start+" ");
            printOneToN(start+1, N);
        }
        public static void ReverseArray(int[] arr)
        {
            // code here
            funReverseArray(arr, 1, arr.Length-1);
        }
        public static void funReverseArray(int[] arr, int n, int i)
        {
            if (n >= arr.Length)
            {
                return;
            }
            int temp = arr[i];
            arr[i] = arr[n];
            arr[n] = temp;
            funReverseArray(arr, n + 1, i-1);            
        }
        public static int computeLongestSubarray(int[] arr,int k)
        {

            // Stores the maximum length subarray so far
            int maxLength = 0;

            // Stores the maximum of current subarray
            int maxOfSub = 0;

            // Stores the minimum of current subarray
            int minOfSub = 0;

            // Initializes the value of maxOfSub to
            // first element of array
            maxOfSub = arr[0];

            // Initializes the value of minOfSub to
            // first element of array
            minOfSub = arr[0];

            // Stores the end pointer for current
            // subarray
            int end = 0;

            // Stores the beginning pointer for
            // current subarray
            int beg = 0;

            // Loop over the given array
            while (end < arr.Length)
            {

                // Stores the current element being
                // added to the subarray
                int currEl = arr[end];

                // If maximum value in the array is less
                // than current element,
                if (maxOfSub < currEl)
                {

                    // Remove indices of all elements smaller
                    // than or equal to current from maxHeap
                    // and set maximum value as current element
                    maxOfSub = currEl;
                }

                // If minimum value in the array is greater
                // than current element,
                if (minOfSub > currEl)
                {

                    // Remove indices of all elements larger
                    // than or equal to current from minHeap
                    // and set minimum value as current element
                    minOfSub = currEl;
                }

                // check if the largest possible difference
                // between a pair of elements <= k
                if (maxOfSub - minOfSub <= k)
                {

                    // Length of current subarray
                    int currLength = end - beg + 1;

                    // Update maxLength
                    if (maxLength < currLength)
                        maxLength = currLength;
                }
                else
                {

                    // If current subarray doesn't satisfy the
                    // condition then remove the starting
                    // element from subarray that satisfy
                    // increment the beginning pointer
                    beg += 1;

                    // If index of max element currently in the
                    // subarray is less than beg
                    if (maxOfSub < beg)
                        maxOfSub = beg;

                    // If index of min element currently in the
                    // subarray is less than beg
                    if (minOfSub < beg)
                        minOfSub = beg;
                }

                end += 1;
            }

            // Return the final answer
            return maxLength;
        }
    }
}