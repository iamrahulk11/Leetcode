namespace LeetCode
{
    using System;
    using System.Collections.Generic;

    public class Sort_Array_Recursion
    {
        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 0, 5, 2 };  // Initialize the list correctly
            sort_array_recursion(arr, arr.Count);

            // Print the sorted array
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }

        public static void sort_array_recursion(List<int> arr, int n)
        {
            // Base condition: If the list size is 1 or 0, it's already sorted
            if (n <= 1)
            {
                return;
            }

            // Recursively sort the first n-1 elements
            sort_array_recursion(arr, n - 1);

            // Take the last element from the sorted array and insert it at the correct position
            int last = arr[n - 1];
            arr.RemoveAt(n - 1);
            insert(arr, last);
        }

        public static void insert(List<int> arr, int temp)
        {
            // Base condition: If the list is empty or temp is greater than or equal to the last element
            if (arr.Count == 0 || arr[arr.Count - 1] <= temp)
            {
                arr.Add(temp);
                return;
            }

            // Remove the last element, recursively insert, and then put the last element back
            int val = arr[arr.Count - 1];
            arr.RemoveAt(arr.Count - 1);
            insert(arr, temp);
            arr.Add(val);
        }
    }

}
