using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Fraction_Addition_and_Subtraction
    {
        public static void Main(string[] args)
        {
            string testcase1 = "-1/3+1/4-1/5+1/6-1/7+1/8-1/9+1/10-1/9+1/10";
            string testcase2 = "1/10-1/10";
            string testcase3 = "1/3-1/2";
            string testcase4 = "1/6-1/6+2/3-2/3";
            string testcase5 = "1/4+3/4";
            string testcase6 = "9/4-5/3+7/2-9/5+10/6-1/7+1/8-2/9+2/10";
            string testcase7 = "-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1-1/1";
            string testcase8 = "-1/3-1/4-1/5-1/6-1/7-1/8-1/9-1/10-1/10-6/10";
            string testcase9 = "-1/2+1/2";

            Console.WriteLine("Result : "+FractionAddition(testcase9));

            Console.ReadLine();

        }
        public static string FractionAddition(string expression)
        {
            string[] nums = Regex.Split(expression,"/|(?=[-+])");
            double a = 0;
            double result = 0;
            List<double> operarion = new();

            foreach (string s in nums) {

                if(string.IsNullOrEmpty(s))
                {
                    continue;
                }
                Console.WriteLine(s+"\t") ;

                if (a == 0)
                {
                    a = Convert.ToInt32(s);
                    continue;
                }
                operarion.Add(Convert.ToDouble(a/Convert.ToDouble(s)));

                a = 0;
            }

            foreach(var value in operarion)
            {
                result += value;
            }

            return result.ToString();
        }
    }
}
