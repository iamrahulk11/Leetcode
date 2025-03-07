
using System;

namespace LeetCode
{
    public class Closest_Prime_Numbers_in_Range
    {
        private static void Main(string[] args)
        {
            int left = 1;
            int right = 10000;

            Console.WriteLine("Answer = {0}", ClosestPrimes(left, right));
            Console.ReadLine();
        }
        public static int[] ClosestPrimes(int left, int right)
        {
            int start = left;
            int minDifference = int.MaxValue;
            int previousPrimeNumber = 0;
            (int, int) result = (-1, -1);

            Dictionary<int, bool> _allPrimeNumbers = SieveOfEratosthenes(right);

            if (left == 1)
            {
                start++;
            }

            while (start <= right)
            {
                if (_allPrimeNumbers[start])
                {
                    if(previousPrimeNumber != 0)
                        minDifference = Math.Min(minDifference, start - previousPrimeNumber);
                         
                    if(minDifference <= (start - previousPrimeNumber))
                    {
                        result.Item1 = previousPrimeNumber;
                        result.Item2 = start;
                    }

                    previousPrimeNumber = start;

                    if (minDifference == 2 || minDifference == 1)
                        break;
                }
                start++;
            }

            return new int[]{ result.Item1, result.Item2 };
        }
        public static Dictionary<int, bool> SieveOfEratosthenes(int right)
        {
            Dictionary<int, bool> sieve = new();
            for (int i = 2; i <= right; i++)
                sieve[i] = true;

            for (int p = 2; p * p <= right; p++)
            {
                if (sieve[p])
                {
                    for (int i = p * p; i <= right; i += p)
                    {
                        sieve[i] = false;
                    }
                }
            }
            return sieve;
        }
    }
}
