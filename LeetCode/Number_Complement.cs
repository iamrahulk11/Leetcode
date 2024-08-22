using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Number_Complement
    {
        public static void Main()
        {
            int num = 5;

            Console.WriteLine(FindComplement(num));

            Console.ReadLine();
        }

        public static int FindComplement(int num)
        {
            double result = 0;
            int count = 0;
            while (num > 0)
            {
                if ((num & 1) == 0)
                {
                    result += Math.Pow(2, count);
                }

                count++;
                num = num >> 1;
            }

            return Convert.ToInt32(result);
        }
    }
}
