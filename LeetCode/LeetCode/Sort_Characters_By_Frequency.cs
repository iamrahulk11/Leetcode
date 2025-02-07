namespace LeetCode
{
    internal class Sort_Characters_By_Frequency
    {
        private static void Main(string[] args)
        {
            string s = "tree";
            string answer = FrequencySort(s);

            Console.WriteLine(answer);

            Console.ReadLine();
        }
        public static string FrequencySort(string s)
        {
            string result = "";
            Dictionary<char, int> str = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (str.ContainsKey(s[i]))
                {
                    str[s[i]] += 1;
                }
                else
                {
                    str.Add(s[i], 1);
                }
            }

            var sorted = str.OrderByDescending(pair => pair.Value)
                        .Select(pair => new string(pair.Key, pair.Value)) 
                        .ToArray();
            
            result = string.Concat(sorted);

            return result;

        }
    }
}
