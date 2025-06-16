namespace LeetCode
{
    class Maximum_Difference_Between_Increasing_Elements
    {
        public static void Main()
        {
            //int[] arr = [7, 1, 5, 4];
            //int[] arr = [9, 4, 3, 2];
            int[] arr = [87, 68, 91, 86, 58, 63, 43, 98, 6, 40];
            Console.WriteLine(MaximumDifference(arr));
            Console.ReadLine();
        }
        public static int MaximumDifference(int[] nums)
        {
            int maxDiff = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j]) {
                        maxDiff = Math.Max(maxDiff, nums[j] - nums[i]);
                    }
                }
            }
            return maxDiff;
        }
        
        //optimized
        public static int MaximumDifference2(int[] nums)
        {
            int maxDiff = -1;
            int preMin = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > preMin)
                {
                    maxDiff = Math.Max(maxDiff, nums[i] - preMin);
                }
                else
                {
                    preMin = nums[i];
                }
            }
            return maxDiff;
        }

    }
}
