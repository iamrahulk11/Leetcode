using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Count_Number_of_Teams
    {
        private static void Main(string[] args)
        {
            ////test case : 1
            //int[] rating = { 2, 5, 3, 4, 1 };

            //test case : 2
            int[] rating = { 1, 2, 3, 4 };

            ////test case : 3
            //int[] rating = { 2,1,3 };

            int answer = NumTeams(rating);

            Console.WriteLine(answer);

            Console.ReadLine();
        }

        public static int NumTeams(int[] rating)
        {
            int count = 0, maxNumber = 0, minNumber = int.MaxValue;
            foreach (int val in rating)
            {
                maxNumber = Math.Max(maxNumber, val);
                minNumber = Math.Min(minNumber, val);
            }

            for (int i = 0; i < rating.Length; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] == maxNumber)
                    {
                        continue;
                    }
                    if (rating[j] == minNumber)
                    {
                        continue;
                    }
                    for (int k = j + 1; k < rating.Length; k++)
                    {
                        if (rating[i] < rating[j])
                        {
                            if (rating[j] < rating[k])
                            {
                                count++;
                            }
                        }
                        if (rating[i] > rating[j])
                        {
                            if (rating[j] > rating[k])
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

    }
}
