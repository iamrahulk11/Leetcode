using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Maximum_Points_You_Can_Obtain_from_Cards
    {
        public static void Main()
        {
            //int[] code = { 5, 7, 1, 4 };
            //int k = 3;
            int[] cardPoints = { 9, 7, 7, 9, 7, 7, 9 };
            int k = 6;
            Console.WriteLine(MaxScore(cardPoints,k));
            Console.ReadLine();
        }
        public static int MaxScore(int[] cardPoints, int k)
        {
            int right = (cardPoints.Length - 1) - k;
            int left = 0;
            int totalSum = 0;
            for (int i = 0; i < cardPoints.Length; i++)
            {
                totalSum += cardPoints[i];
            }
            if (right < 0)
            {
                return totalSum;
            }

            int sum = Int32.MaxValue;
            int calSum = 0;
            for (int i = left; i <= right; i++)
            {
                calSum += cardPoints[i];
            }
            sum = Math.Min(sum, calSum);
            while (right <= (cardPoints.Length - 1))
            {
                calSum -= cardPoints[left];
                right++;
                if (right > (cardPoints.Length - 1))
                    break;

                calSum += cardPoints[right];
                left++;
                
                sum = Math.Min(sum, calSum);
            }
            return totalSum - sum;

        }        
    }
}
