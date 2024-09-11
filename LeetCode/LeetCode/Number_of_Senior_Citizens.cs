using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Number_of_Senior_Citizens
    {
        private static void Main(string[] args)
        {
            string[] details = { "7868190130M7522", "5303914400F9211", "9273338290F4010" };
            int result = CountSeniors(details);

            Console.WriteLine($"Answer: {result}");
            Console.ReadLine();
        }
        public static int CountSeniors(string[] details)
        {
            int count = 0;
            foreach (string value in details)
            {
                int age = Convert.ToInt32(value.Substring(11, 2));
                if (age > 60)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
