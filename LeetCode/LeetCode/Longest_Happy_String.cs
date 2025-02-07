using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Longest_Happy_String
    {
        public static void Main(string[] args)
        {
            int a = 2, b = 2, c = 1;
            Console.WriteLine(LongestDiverseString(a, b, c));
            Console.ReadLine();
        }
        public static string LongestDiverseString(int a, int b, int c)
        {
            string result = string.Empty;

            string theMax = string.Empty;
            int maxCount = 0;

            if (a >= b && a >= c)
            {
                theMax = "a";
                maxCount = a;
            }

            if(b >= c && b >= a)
            {
                theMax = "b";
                maxCount = b;
            }

            if (c >= a && c >= b)
            {
                theMax = "c";
                maxCount = c;
            }

            int printCount = 0;

            for (int i = 0; i <= maxCount; i++)
            {
                if(theMax == "a")
                {
                    if (printCount != 2)
                    {
                        result += "a";
                        printCount++;
                    }
                    else
                    {
                        if (b != 0)
                        {
                            result += "b";
                            printCount = 0;
                            b--;
                        }
                        else if (c != 0)
                        {
                            result += "c";
                            printCount = 0;
                            c--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                if (theMax == "b")
                {
                    if (printCount != 2)
                    {
                        result += "b";
                        printCount++;
                    }
                    else
                    {
                        if (a != 0)
                        {
                            result += "a";
                            printCount = 0;
                            a--;
                        }
                        else if (c != 0)
                        {
                            result += "c";
                            printCount = 0;
                            c--;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                if (theMax == "c")
                {
                    if (printCount != 2)
                    {
                        result += "c";
                        printCount++;
                    }
                    else
                    {
                        if (b != 0)
                        {
                            result += "b";
                            printCount = 0;
                            b--;
                        }
                        else if (a != 0)
                        {
                            result += "a";
                            printCount = 0;
                            a--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
