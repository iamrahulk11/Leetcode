using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class Convert_Date_to_Binary
    {
        public static void Main(string[] args)
        {
            string date = "2080-02-29";
            Console.WriteLine("Converted string : "+convertDateToBinary(date));

            Console.ReadLine();
        }

        public static string convertDateToBinary(string date)
        {
            string convertedString = string.Empty;
            int start = 0;
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '-' || (i + 1) == date.Length)
                {
                    convertedString += decToBinary(Convert.ToInt32(date.Substring(start, string.IsNullOrEmpty(convertedString) ? 4 : 2)));

                    if((i+1) == date.Length)
                    {
                        break;
                    }

                    start = i+1;
                    convertedString += "-";
                }
                
            }

            return convertedString;
        }
        private static string decToBinary(int n)
        {
            string binary = "";
            int[] binaryNum = new int[32];

            int i = 0;
            while (n > 0)
            {
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
                binary += binaryNum[j];

            return binary;
        }
    }
}
