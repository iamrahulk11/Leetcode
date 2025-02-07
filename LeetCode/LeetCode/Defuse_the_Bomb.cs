using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Defuse_the_Bomb
    {
        public static void Main()
        {
            //int[] code = { 5, 7, 1, 4 };
            //int k = 3;
            int[] code = { 2, 4, 9, 3 };
            int k = -2;

            int[] result = Decrypt(code, k);
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }

        public static int[] Decrypt(int[] code, int k)
        {
            int[] ints = new int[code.Length];

            if (k == 0)
            {
                return new int[code.Length];
            }
            else if (k > 0)
            {
                int count = 0;
                int sum = 0;
                for(int i = 0; i < code.Length; i++)
                {
                    int index = (i+1)%code.Length;
                    while (count!=k && index!=i)
                    {
                        sum+= code[index];
                        index = (index+1) % code.Length; ;
                        count++;
                    }
                    ints[i] = sum;
                    sum = 0;
                    index = 0;
                    count = 0;
                }
            }
            else
            {
                int count = 0;
                int sum = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    int index = 0;
                    if (i > 0)
                    {
                        index = (code.Length - 1 + i ) % code.Length;
                    }
                    else
                    {
                        index = (code.Length - 1 + i) % code.Length;
                    }
                    while (count != k*(-1) && index != i)
                    {
                        sum += code[index];
                        index = (code.Length - 1 + index) % code.Length;
                        count++;
                    }
                    ints[i] = sum;
                    sum = 0;
                    index = 0;
                    count = 0;
                }
            }

            return ints;
        }
    }
}
