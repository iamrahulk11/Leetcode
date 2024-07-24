using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Radix_Sort
    {
        public static void RadixSort(int[] array)
        {
            int max = array.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(array, exp);
            }
        }

        private static void CountingSortByDigit(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
    }
}
