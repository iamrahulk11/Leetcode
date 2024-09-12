namespace LeetCode.DSA.Binary_Search
{
    internal class LC35_Search_Insert_Position
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;

            Console.WriteLine("Result : "+ SearchInsert(nums, target));

            Console.ReadLine();
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length-1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] >= target)
                {
                    end = mid-1;
                }
                else
                {
                    start = mid+1;
                }
            }
            return start;
        }
    }
}
