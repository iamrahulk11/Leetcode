using System.Text.RegularExpressions;

namespace LeetCode
{
    internal class Sort_Array_by_Increasing_Frequency
    {
        private static void Main(string[] args)
        {
            int[] arr = { -1, 1, -6, 4, 5, -6, 1, 4, 1 };

            int[] result = FrequencySort(arr);

            foreach (int i in result)
            {
                Console.WriteLine("values : "+i);
            }

            Console.ReadLine();
        }

        public static int[] FrequencySort(int[] nums)
        {
            int[] result = new int[nums.Length];
            var frequency = nums.GroupBy(x => x)
                               .ToDictionary(g => g.Key, g => g.Count());

            var groupedByDistinctCount = frequency.GroupBy(kv => kv.Value, kv => kv.Key)
                                              .OrderBy(g => g.Key)
                                              .Select(g => g.OrderByDescending(x => x))
                                              .ToList();

            int index = 0;
            foreach (var group in groupedByDistinctCount)
            {
                foreach (var number in group)
                {
                    for (int i = 0; i < frequency[number]; i++)
                    {
                        result[index++] = number;
                    }
                }
            }

            return result;
        }
    }
}
