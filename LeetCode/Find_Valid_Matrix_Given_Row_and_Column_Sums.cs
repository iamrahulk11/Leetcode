using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Find_Valid_Matrix_Given_Row_and_Column_Sums
    {
        private static void Main(string[] agg)
        {
            //Test case : 1
            //int[] rowSum = { 3,8 };
            //int[] colSum = { 4,7 };

            //Test case : 2
            //int[] rowSum = { 5, 7, 10 };
            //int[] colSum = { 8, 6, 8 };

            //Test case : 3
            int[] rowSum = { 14, 9 };
            int[] colSum = { 6, 9, 8 };

            var answer = RestoreMatrix(rowSum, colSum);

            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Console.Write(answer[i][j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Loop in to the row and col then compare the value and pick the minimum one and put it in result
        /// and minus it to row as well as column of sum row and sum column.
        /// For test case 3 :
        /// row sum : [14    9]
        /// col sum : [6     9     8]
        /// 
        /// result : 
        /// [14    9]
        /// [6     9     8]
        /// 
        /// 0    0    0
        /// 0    0    0
        /// For ( i = 0 )
        /// iterate 1 : 
        /// [8     9]
        /// [0     9     8]
        /// 
        /// (min(14 , 6) 6)      0     0
        /// (6-6)                0     0
        /// 
        /// iterate 2 : 
        /// [0     9]
        /// [0     1     8]
        /// 
        /// (6)     (min(8,9) 8)      0
        /// 0            0            0
        /// 
        /// iterate 3 : 
        /// [0     9]
        /// [0     1     8]
        /// 
        /// (6)          8        (min(0,8) 0)
        /// 0            0            0
        /// 
        /// For ( i = 1 )
        /// iterate 1 : 
        /// [0     9]
        /// [0     1     8]
        /// 
        /// (6)                     8            0 
        /// (min(0,9) 0)            0            0
        /// 
        /// iterate 2 : 
        /// [0     8]
        /// [0     0     8]
        /// 
        /// (6)                     8             0
        /// 0                 (min(1,9) 1)        0
        /// 
        /// iterate 3 : 
        /// [0     0]
        /// [0     0     0]
        /// 
        /// (6)           8        0 
        /// 0             1      (min(8,8) 8)
        /// 
        /// result :
        /// 6       8       0
        /// 0       1       8
        /// </summary>
        /// <param name="rowSum">LENGTH OF ROW</param>
        /// <param name="colSum">LENGTH OF COLUMN</param>
        /// <returns></returns>
        public static int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int row_len = rowSum.Length;
            int col_len = colSum.Length;
            int[,] result = new int[row_len,col_len];

            for (int i = 0; i < row_len; i++)
            {
                for (int j = 0; j < colSum.Length; j++)
                {
                    int x = Math.Min(rowSum[i], colSum[j]);
                    result[i,j] = x;
                    rowSum[i] -= x;
                    colSum[j] -= x;
                }
            }
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            int[][] returnArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                returnArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    returnArray[i][j] = result[i, j];
                }
            }
            return returnArray;
        }
    }
}
