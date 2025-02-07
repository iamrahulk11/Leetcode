namespace LeetCode
{
    internal class Special_Array_I
    {
        private static void Main(string[] args)
        {
            int[] nums = { 4, 3, 1, 6 };
            bool answer = IsArraySpecial(nums);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static bool IsArraySpecial(int[] nums)
        {
            bool isEven = nums[0] % 2 == 0 ? true : false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && isEven)
                {
                    return false;
                }

                if (nums[i] % 2 != 0 && !isEven)
                {
                    return false;
                }
                isEven = nums[i] % 2 == 0 ? true : false;
            }
            return true;
        }
    }
}
