namespace LeetCode
{
    internal class Subarrays_with_K_Different_Integers
    {
        public static void Main()
        {
            int[] nums = { 1, 2, 1, 2, 3 };
            int k = 2;
            Console.WriteLine(SubarraysWithKDistinct(nums, k));
            Console.ReadLine();
        }

        public static int SubarraysWithKDistinct(int[] nums, int k)
        {
            return (countCalculate(nums, k) - countCalculate(nums, k-1));
        }
        public static int countCalculate(int[] nums, int k)
        {
            int start = 0, end = 0, count=0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            while (start < nums.Length && end < nums.Length)
            {
                if (!map.ContainsKey(nums[end]))
                {
                    map.Add(nums[end], 1);
                }
                else
                {
                    map[nums[end]]++;
                }

                while (map.Count > k)
                {
                    map[nums[start]]--;

                    if (map[nums[start]] == 0)
                    {
                        map.Remove(nums[start]);
                    }
                    start++;
                }     

                count += (end - start) + 1;
                end++;
            }
            return count;
        }
    }
}
