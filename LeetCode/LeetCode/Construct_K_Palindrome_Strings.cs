namespace LeetCode
{
    internal class Construct_K_Palindrome_Strings
    {
        private static void Main(string[] args)
        {
            string s = "yzyzyzyzyzyzyzy";
            int k = 2;
            bool answer = CanConstruct(s,k);

            Console.WriteLine(answer);

            Console.ReadLine();
        }

        public static bool CanConstruct(string s, int k)
        {
            Dictionary<char,int> frequency = s.GroupBy(character => character).ToDictionary(currentKey => currentKey.Key, currentKey => currentKey.Count());
            int totalOddFrequency = 0;

            foreach (var dic in frequency.Values)
            {
                if (dic % 2 != 0)
                {
                    totalOddFrequency++;
                }
                
                if (totalOddFrequency > k)
                {
                    return false;
                }
            }

            return true;            
        }
    }
}
