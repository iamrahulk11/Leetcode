namespace LeetCode
{
    public class search_in_2D_array
    {
        public static void Main()
        {
            int[][] arr = [[1, 4, 7, 11, 15],[2, 5, 8, 12, 19],[3, 6, 9, 16, 22],[10, 13, 14, 17, 24],[18, 21, 23, 26, 30]];
            //int[][] arr = [[1, 1]];
            int target = 5;

            Console.WriteLine(SearchMatrix(arr, target));
            Console.ReadLine();
        }

        /// <summary>
        /// SEARCH IN 2D MATRIX II
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int col = 0; 
            int row = matrix.Length-1;

            while (col < matrix[0].Length && row >= 0)
            {
                if (matrix[row][col] == target)
                {
                    return true;
                }

                if(matrix[row][col] > target)
                {
                    row--;
                }
                else if (matrix[row][col] < target)
                {
                    col++;
                }
            }

            return false;
        }


        /// <summary>
        /// SEARCH IN 2D MATRIX
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool targetPresent(int[][] arr, int target)
        {
            int low = 0;
            int high = arr[0].Length * arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid / arr[0].Length][mid % arr[0].Length] == target)
                {
                    return true;
                }
                if (arr[mid / arr[0].Length][mid % arr[0].Length] > target)
                {
                    high = mid - 1;
                }
                if (arr[mid / arr[0].Length][mid % arr[0].Length] < target)
                {
                    low = mid + 1;
                }

            }
            return false;
        }
    }
}
