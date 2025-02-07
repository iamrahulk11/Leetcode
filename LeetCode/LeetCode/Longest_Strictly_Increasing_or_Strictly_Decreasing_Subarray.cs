namespace LeetCode
{
    internal class Longest_Strictly_Increasing_or_Strictly_Decreasing_Subarray
    {
        private static void Main(string[] args)
        {
            int[] nums = { 1, 4, 3, 3, 2 };
            int answer = LongestMonotonicSubarray(nums);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static int LongestMonotonicSubarray(int[] nums)
        {
            int incLength = 1, decLength = 1, maxLength = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    incLength++;
                    decLength = 1;
                }
                else if (nums[i + 1] < nums[i])
                {
                    decLength++;
                    incLength = 1;
                }
                else
                {
                    incLength = 1;
                    decLength = 1;
                }
                maxLength = Math.Max(maxLength, Math.Max(incLength, decLength));
            }

            return maxLength;

        }
    }
}
