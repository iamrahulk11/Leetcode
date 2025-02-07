namespace LeetCode
{
    internal class Binary_Subarrays_With_Sum
    {
        public static void Main()
        {
            int[] nums = { 1, 0, 1, 0, 1 };
            int goal = 2;

            Console.WriteLine("Answer = {0}", NumSubarraysWithSum(nums, goal) - NumSubarraysWithSum(nums, goal-1));
            Console.ReadLine();
        }
        public static int NumSubarraysWithSum(int[] nums, int goal)
        {
            int left = 0, right = 0, sum = 0, answer = 0;
            if(goal < 0)
            {
                return 0;
            }

            while (right < nums.Length)
            {
                sum += nums[right];
                
                while(goal < sum)
                {
                    sum -= nums[left];
                    left++;
                }

                answer += right - left + 1;
                right++;                
            }

            return answer;
        }
    }
}