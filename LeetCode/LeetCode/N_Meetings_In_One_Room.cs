using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class N_Meetings_In_One_Room
    {
        public static void Main()
        {
            // test case 1 : start [1, 3, 0, 5, 8, 5], end[] = [1, 3, 0, 5, 8, 5]
            //int[] start = { 1, 3, 0, 5, 8, 5 };
            //int[] end = { 2, 4, 6, 7, 9, 9 };

            int[] start = { 75250, 50074, 43659, 8931, 11273, 27545, 50879, 77924 };
            int[] end = { 112960, 114515, 81825, 93424, 54316, 35533, 73383, 160252 };
            int arrayLength = 8;

            Console.WriteLine(maxMeetings(arrayLength, start, end));

            Console.ReadLine();
        }

        public static int maxMeetings(int n, int[] start, int[] end)
        {
            int[] slots = new int[findMaxElement(end) + 1];
            int count = 0;
            for (int i = 0; i < start.Length; i++)
            {
                int diff = end[i] - start[i];
                if (checkOne(start[i], end[i], slots))
                {
                    continue;
                }
                count++;
            }
            return count;
        }

        public static bool checkOne(int start, int end, int[] slots)
        {
            for (int i = start; i <= end; i++)
            {
                if (slots[i] == 1)
                {
                    return true;
                }
            }
            for (int i = start; i <= end; i++)
            {
                slots[i] = 1;
            }

            return false;
        }

        public static int findMaxElement(int[] end)
        {
            int maxElement = 0;

            foreach (int val in end)
            {
                if (val > maxElement)
                {
                    maxElement = val;
                }
            }
            return maxElement;
        }
    }
}
