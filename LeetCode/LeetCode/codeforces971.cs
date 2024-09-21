class Program
{
    public static void Main(){
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            long[] inputs = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = inputs[0], y = inputs[1], k = inputs[2];

            long moves = 0;

            long movesXCordinates = (x + k - 1) / k;
            long movesYCordinates = (y + k - 1) / k;

            moves = movesXCordinates + movesYCordinates - 1;

            Console.WriteLine(moves);
        }
    }
}
