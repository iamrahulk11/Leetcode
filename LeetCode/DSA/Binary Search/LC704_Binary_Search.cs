namespace LeetCode.DSA.Binary_Search
{
    //Basic Binary Search
    internal class LC704_Binary_Search
    {
        public static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 2;
            Console.WriteLine("Result: "+Search(nums, target));
            Console.ReadLine();
        }
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
