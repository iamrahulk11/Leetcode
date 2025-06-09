namespace LeetCode
{
    class Surrounded_Regions
    {
        public static void Main()
        {
            //char[][] grid = [['X', 'X', 'X', 'X'], ['X', 'O', 'O', 'X'], ['X', 'X', 'O', 'X'], ['X', 'O', 'X', 'X']];
            //char[][] grid = [['O', 'O'], ['O', 'O']];
            char[][] grid = [['O', 'O', 'O'], ['O', 'O', 'O'], ['O', 'O', 'O']];

            Solve(grid);

            foreach (var item in grid)
            {
                foreach (var val in item)
                {
                    Console.Write(val);
                    Console.Write(" ");
                }
            }
            Console.ReadLine();

        }
        public static void Solve(char[][] board)
        {
            int n = board.Length;
            int m = board[0].Length;

            int[,] isVisited = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (board[row][col] == 'O' && isVisited[row, col] == 0)
                    {
                        bfs(row, col, board, isVisited);
                    }
                }
            }
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
        // keep the tract of visited pairs and a flag which ensure the chain is connected to the edges or not
        // Note : needs to be optimize
        private static void bfs(int row, int col, char[][] board, int[,] isVisited)
        {
            int n = board.Length;
            int m = board[0].Length;

            Queue<Pair> pairs = new();
            Queue<Pair> Savedpairs = new();
            pairs.Enqueue(new Pair(row, col));
            Savedpairs.Enqueue(new Pair(row, col));

            bool isEdge = false;

            while (pairs.Count > 0)
            {
                int prow = pairs.Peek().first;
                int pcol = pairs.Peek().second;
                pairs.Dequeue();

                if ((prow - 1) >= 0 && board[prow - 1][pcol] == 'O' && isVisited[prow - 1, pcol] == 0)
                {
                    isVisited[prow - 1, pcol] = 1;
                    pairs.Enqueue(new Pair(prow - 1, pcol));
                    Savedpairs.Enqueue(new Pair(prow - 1, pcol));
                }
                if ((pcol + 1) < m && board[prow][pcol + 1] == 'O' && isVisited[prow, pcol + 1] == 0)
                {
                    isVisited[prow, pcol + 1] = 1;
                    pairs.Enqueue(new Pair(prow, pcol + 1));
                    Savedpairs.Enqueue(new Pair(prow, pcol + 1));
                }
                if ((prow + 1) < n && board[prow + 1][pcol] == 'O' && isVisited[prow + 1, pcol] == 0)
                {
                    isVisited[prow + 1, pcol] = 1;
                    pairs.Enqueue(new Pair(prow + 1, pcol));
                    Savedpairs.Enqueue(new Pair(prow + 1, pcol));
                }
                if ((pcol - 1) >= 0 && board[prow][pcol - 1] == 'O' && isVisited[prow, pcol - 1] == 0)
                {
                    isVisited[prow, pcol - 1] = 1;
                    pairs.Enqueue(new Pair(prow, pcol - 1));
                    Savedpairs.Enqueue(new Pair(prow, pcol - 1));
                }
                if (prow == 0 || prow == (n - 1) || pcol == 0 || pcol == (m - 1) && board[prow][pcol] == 'O')
                {
                    isEdge = true;
                }
                
            }

            if (!isEdge)
            {
                foreach (var item in Savedpairs)
                {
                    board[item.first][item.second] = 'X';
                }
            }
        }
    }
}
