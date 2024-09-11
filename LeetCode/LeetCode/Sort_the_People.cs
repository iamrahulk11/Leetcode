using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Sort_the_People
    {
        public static void Main()
        {
            string[] names = { "Mary", "John", "Emma" };
            int[] heights = { 180, 165, 170 };

            string[] result = SortPeople(names, heights);
            foreach (var val in result)
            {
                Console.WriteLine($"name : {val}");
            }

            Console.ReadLine();
        }

        public static string[] SortPeople(string[] names, int[] heights)
        {
            Dictionary<int, string> Pvalues = new();

            for (int i = 0; i < heights.Length; i++)
            {
                Pvalues.Add(heights[i], names[i]);
            }

            string[] sortedValues = Pvalues.OrderByDescending(kvp => kvp.Key)
                                            .Select(kvp => kvp.Value)
                                            .ToArray();

            return sortedValues;
        }
    }
}
