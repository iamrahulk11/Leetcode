using System.Numerics;

namespace LeetCode
{
    internal class Trapping_Rain_Water
    {
        private static void Main(string[] args)
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            //int[] height = { 4, 2, 0, 3, 2, 5 };
            //int[] height = { 4, 2, 3 };
            int answer = Trap2(height);

            Console.WriteLine(answer);

            Console.ReadLine();
        }

        public static int Trap2(int[] height)
        {
            int[] left = new int[height.Length];
            int[] right = new int[height.Length];

            left[0] = height[0];
            right[height.Length-1] = height[height.Length-1];
            for (int i = 1; i < height.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], height[i]);
            }

            for (int i = height.Length-2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], height[i]);
            }

            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                result += Math.Min(left[i], right[i]) - height[i];
            }
            return result;
        }

        public static int Trap(int[] height)
        {
            int result = 0;
            int start = 0, end = 1, currentAnswer = 0, periodSum = 0;
            while (start != height.Length - 1)
            {
                currentAnswer = 0;
                if (end >= height.Length)
                {
                    start++;
                    end = start + 1;
                    periodSum = 0;
                    continue;
                }

                if (height[start] <= height[end])
                {
                    start = end;
                    result += periodSum;
                    periodSum = 0;
                    end++;
                    continue;
                }
                
                currentAnswer = height[start] - height[end];
                periodSum += currentAnswer;
                end++;
            }
            return result;
        }


    }
}
