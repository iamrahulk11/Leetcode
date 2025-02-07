using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Tuple_with_Same_Product
    {
        private static void Main(string[] args)
        {
            int[] nums = { 2, 3, 4, 6, 8, 12 };
            int answer = TupleSameProduct(nums);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static int TupleSameProduct(int[] nums)
        {
            Dictionary<int, int> dic = new();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for(int k = i+1; k < nums.Length; k++)
                {
                    int mul = nums[i] * nums[k];
                    if (dic.ContainsKey(mul))
                    {
                        dic[mul]++;
                    }
                    else
                    {
                        dic.Add(mul, 1);
                    }
                }                
            }
            int answer = 0;
            foreach (var key_value in dic)
            {
                answer += (key_value.Value - 1) * key_value.Value * 4;
            }
            return answer;
        }
    }
}
