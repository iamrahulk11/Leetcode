namespace LeetCode
{
    internal class Lexicographical_Numbers
    {
        private static void Main(string[] args)
        {

            int n = 13;
            //output : [1,10,11,12,13,2,3,4,5,6,7,8,9]

            IList<int> numbers = new List<int>();
            numbers = LexicalOrder(n);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
        public static IList<int> LexicalOrder(int n)
        {
            IList<int> numbers = new List<int>();
            numbers.Add(1);
            int current = 1;
            for(int i = 2; i <= n; i++)
            {
                if ((current * 10) <= n)
                {
                    current = current * 10;                   
                }
                else
                {
                    while ((current % 10) == 9 || current >= n)
                    {
                        current = current / 10;                        
                    }
                    current = current + 1;
                }
                numbers.Add(current);
            }
            return numbers;
        }
    }
}
