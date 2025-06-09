namespace LeetCode
{
    // Two Problem Solution : Number of island and Max area of the island
    class NumberOfIsland
    {
        public static void Main()
        {
            //int[][] grid = [
            //                [0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0], 
            //                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], 
            //                [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0], 
            //                [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0], 
            //                [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0], 
            //                [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0], 
            //                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], 
            //                [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]
            //                ];

            int[][] grid = [[1]];

            Console.WriteLine(NumIslands(grid));

        }
        public static int NumIslands(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            int[,] isVisited = new int[n, m];
            int largestArea = 0;
            int currentArea = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (grid[row][col] == 1 && isVisited[row, col] == 0)
                    {
                        largestArea = 1;
                        currentArea = bfsMapVisitedFourDirection(row, col, isVisited, grid);
                        largestArea = Math.Max(largestArea, currentArea);
                    }
                }
            }
            return largestArea;
        }
        public class Pair
        {
            public int first;
            public int second;
            public Pair(int firstValue, int secondValue)
            {
                this.first = firstValue;
                this.second = secondValue;
            }
        }        

        // 4 directions
        private static int bfsMapVisitedFourDirection(int row, int col, int[,] isVisited, int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            Queue<Pair> pairs = new();
            pairs.Enqueue(new Pair(row, col));

            int area = 0;

            while (pairs.Count > 0)
            {
                int nrow = pairs.Peek().first;
                int ncol = pairs.Peek().second;
                pairs.Dequeue();

                if ((nrow - 1) >= 0 && grid[nrow - 1][ncol] == 1 && isVisited[nrow - 1, ncol] == 0)
                {
                    isVisited[nrow - 1, ncol] = 1;
                    pairs.Enqueue(new Pair(nrow - 1, ncol));
                    area++;
                }
                if ((ncol + 1) < m && grid[nrow][ncol + 1] == 1 && isVisited[nrow, ncol + 1] == 0)
                {
                    isVisited[nrow, ncol + 1] = 1;
                    pairs.Enqueue(new Pair(nrow, ncol + 1));
                    area++;
                }
                if ((nrow + 1) < n && grid[nrow + 1][ncol] == 1 && isVisited[nrow + 1, ncol] == 0)
                {
                    isVisited[nrow + 1, ncol] = 1;
                    pairs.Enqueue(new Pair(nrow + 1, ncol));
                    area++;
                }
                if ((ncol - 1) >= 0 && grid[nrow][ncol - 1] == 1 && isVisited[nrow, ncol - 1] == 0)
                {
                    isVisited[nrow, ncol - 1] = 1;
                    pairs.Enqueue(new Pair(nrow, ncol - 1));
                    area++;
                }

            }
            if(area == 0)
            {
                return 1;
            }
            return area;
        }

        // 8 directions
        private static void bfsMapVisited(int row, int col, int[,] isVisited, int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            Queue<Pair> pairs = new();
            pairs.Enqueue(new Pair(row, col));

            while (pairs.Count > 0)
            {
                int nrow = pairs.Peek().first;
                int ncol = pairs.Peek().second;
                pairs.Dequeue();

                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        int rotatedRow = nrow + i;
                        int rotatedCol = ncol + j;

                        if (rotatedRow >= 0 && rotatedRow < n && rotatedCol >= 0 && rotatedCol < m &&
                            grid[rotatedRow][rotatedCol] == 1 && isVisited[rotatedRow, rotatedCol] == 0)
                        {
                            isVisited[rotatedRow, rotatedCol] = 1;
                            pairs.Enqueue(new Pair(rotatedRow, rotatedCol));
                        }
                    }
                }
            }
        }
    }
}
