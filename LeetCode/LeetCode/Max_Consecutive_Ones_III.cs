namespace LeetCode
{
    internal class Max_Consecutive_Ones_III
    {
        public static void Main()
        {
            //int[] code = { 5, 7, 1, 4 };
            //int k = 3;            
            int[] nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int k = 3;

           Console.WriteLine("Answer = {0}",LongestOnes(nums, k));
           
            Console.ReadLine();
        }
        public static int LongestOnes(int[] nums, int k)
        {
            int countZero = 0, count = 0, left = 0, result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count = (i - left) + 1;
                }
                else
                {
                    if (countZero < k)
                    {
                        countZero++;
                    }
                    else
                    {
                        if (nums[left] == 0)
                        {
                            left++;
                        }
                        else
                        {
                            while (nums[left] == 1)
                            {
                                left++;
                            }
                        }
                        countZero--;
                        
                    }
                }
                count = (i - left) + 1;
                result = Math.Max(count, result);
            }
            return result;
        }
    }
}
